import numpy as np
from numpy.core.records import array
from sklearn.datasets import make_classification
import random as rd

def distance_by_euclidian(x: list, y: list) -> float:
	return ((x[0] - x[1])**2 + (y[0] - y[1])**2)**(1/2)

def KMeans(n_cluster: int, data: list):
	m, n = data.shape
	Centroids = np.array([]).reshape(n, 0)

	for _ in range(n_cluster):
		rand = rd.randint(0, m - 1)
		Centroids = np.c_[Centroids, data[rand]]
	pass



data, _ = make_classification(n_samples=1000, n_features=2, n_informative=2, n_redundant=0, n_clusters_per_class=1, random_state=4)

m, n = data.shape

n_iter = 100
K = 2

Centroids = np.array([]).reshape(n, 0)

