import random, copy

class Object:
	def __repr__(self):
		return '<%s>' % getattr(self, '__name__', self.__class__.__name__)
	def is_alive(self):
		return hasattr(self, 'alive') and self.alive

class Agent(Object):
	def __init__(self):
		def program(percept):
			return input('Percept=%s; action? ' % percept)		
		self.program = program
		self.alive = True

def TraceAgent(agent):
#Агентын програмыг оролт, гаралтыг багцалж хэвлэнэ. Энэ нь агент тухайн
#орчинд юу хийж байгааг харуулна.
	old_program = agent.program
	def new_program(percept):
		action = old_program(percept)
		print('%s perceives %s and does %s' % (agent, percept, action))
		return action
	agent.program = new_program
	return agent


class TableDrivenAgent(Agent):
	#Энэ агент нь орны буулгалтын дараалалд үндэслэн тохирох хариу үйлдлийг
	#сонгоно. Энэ нь зөвхөн жижиг домэйнуудад л ашиглагддаг. Үүнийг өөрчлөхийн
	#тулд та байгуулагчид хүснэгт өгнө.
	def __init__(self, table):
		#Бүх {percept_sequence: action} хосуудын толь бичгийг хүснэгт
		#болгон оруулна."
		#Агент програм нь зарчмын хувьд функц байж болох юм, гэхдээ class-ийн
		#дуудаж болох instance хэлбэрээр төлвүүдийг хадгалах хэрэгтэй.
		Agent.__init__(self)
		percepts = []
		def program(percept):
			percepts.append(percept)
			action = table.get(tuple(percepts))
			return action
		self.program = program

loc_A, loc_B = (0, 0), (1, 0) # Вакуум ертөнцийн хоёр байршил

def TableDrivenVacuumAgent():
	table = {((loc_A, 'Clean'),): 'Right',
	((loc_A, 'Dirty'),): 'Suck',
	((loc_B, 'Clean'),): 'Left',
	((loc_B, 'Dirty'),): 'Suck',
	((loc_A, 'Clean'), (loc_A, 'Clean')): 'Right',
	((loc_A, 'Clean'), (loc_A, 'Dirty')): 'Suck',
	# ...
	((loc_A, 'Clean'), (loc_A, 'Clean'), (loc_A, 'Clean')): 'Right',
	((loc_A, 'Clean'), (loc_A, 'Clean'), (loc_A, 'Dirty')): 'Suck',
	# ...
	}
	return TableDrivenAgent(table)

class RandomAgent(Agent):
	#Бүх орчны буулгалтыг үл тоомсорлож, санамсаргүй байдлаар
	#үйлдлийг сонгодог төлөөлөгч.
	def __init__(self, actions):
		Agent.__init__(self)
		self.program = lambda: random.choice(actions)


def RandomVacuumAgent():
	#Вакуум орчноос нэг үйлдлийг санамсаргүй байдлаар сонгоно
	return RandomAgent(['Right', 'Left', 'Suck', 'NoOp']).program()

class Environment:
	#Орчныг харуулсан хийсвэр анги. Үүнээс 'бодит' орчныг удамшуулж үүсгэнэ.
	#Орчин нь ихэвчлэн дараахь зүйлийг хэрэгжүүлэх шаардлагатай болно.
	#орчны тусгал: Агент хардаг ойлголтыг тодорхойл.
	#execute_action: Гүйцэтгэж байгаа үйлдлийн үр дүнг тодорхойлох.
	#Agent.performance slot-ийг шинэчлэх. Хүрээлэн буй орчны .objects болон .agents
	#жагсаалтыг хадгалдаг (энэ нь дэд хэсэг юм). Агент бүр нь 0-ээр эхэлсэн
	#гүйцэтгэлийн үүр байна. Обьект бүр нь .location slot-тэй байдаг, гэхдээ зарим
	#орчинд байхгүй байж болно.
	def __init__(self,):
		self.objects = []; self.agents = []
	
	object_classes = [] ## Орчинд нэвтрэх боломжтой хичээлүүдийн жагсаалт

	def percept(self, agent):
		#Агентын харж буй ойлголтыг буцаана. Засварлаж утга оруулна
		pass
	def execute_action(self, agent, action):
		#Үйлдэл хийхэд хамаарах ертөнцийг өөрчил. Засварлаж утга оруулна
		pass
	def default_location(self, object):
		#Тодорхойгүй байршилтай шинэ объектыг байрлуулах үндсэн байршил
		return None
	def exogenous_change(self):
		#Хэрэв дэлхий дээр тогтмол өөрчлөгдөж байгаа бол засварлаж утга оруул
		pass
	def is_done(self):
		#Амьд агент олж чадахгүй байх үед дуусна
		for agent in self.agents:
			if agent.is_alive(): return False
		return True
	def step(self):
		#Орчныг нэг удаагийн алхамаар ажиллуулна. Хэрэв үйлдлүүд ба гадны
		#өөрчлөлтүүд нь хамааралгүй бол энэ аргыг хийх болно. Хэрэв тэдгээрийн
		#хооронд харилцан хамаарал байгаа бол энэ аргыг засаж бичнэ.
		if not self.is_done():
			actions = [agent.program(self.percept(agent))
				for agent in self.agents]
			for (agent, action) in zip(self.agents, actions):
				self.execute_action(agent, action)
			self.exogenous_change()
	def run(self, steps=1000):
		#Хүрээлэн буй орчныг өгөгдсөн тооны алхамаар ажиллуулна
		for step in range(steps):
			if self.is_done(): return
			self.step()
	def add_object(self, object, location=None):
		#Хүрээлэн буй орчинд объектыг нэмж байршлыг тохируулна. Мөн агентууд
		#төрлийн объектуудыг хянана.
		object.location = location or self.default_location(object)
		self.objects.append(object)
		if isinstance(object, Agent):
			object.performance = 0
			self.agents.append(object)
		return self