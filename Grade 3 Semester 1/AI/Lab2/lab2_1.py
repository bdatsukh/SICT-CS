import random

class RandomAgent:
	def __init__(self, percept):
		print((lambda choice: {'Dirty': 'Suck', 'Right': 'Left', 'Left': 'Right', 'NoOp': 'NoOp'}[choice])(percept))

def randomvacuumagent():
	print("Вакуум орчноос нэг үйлдлийг percept-ээс хамаарна сонгоно.")	
	RandomAgent(random.choice(['Dirty', 'Right', 'Left', 'NoOp']))

randomvacuumagent()