

class Graph:
	def __init__(self):
		self.visited = {}
		self.adj = {}

	def addEdge(self, v: int, w: int):
		if v not in self.adj:
			self.adj[v] = []

		self.adj[v].append(w)
	
	def DFS(self, v: int):
		self.visited[v] = True
		print(f'{v} + ')

		for i in self.adj[v]:
			if self.visited[i] == False:
				self.DFS(i)

if __name__ == '__main__':
	graph = Graph()

	graph.addEdge(0, 1)
	graph.addEdge(0, 2)
	graph.addEdge(1, 2)
	graph.addEdge(2, 0)
	graph.addEdge(2, 3)
	graph.addEdge(3, 3)

	graph.DFS(2)