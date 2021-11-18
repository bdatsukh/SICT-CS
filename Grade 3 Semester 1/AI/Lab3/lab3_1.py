import numpy as np
from numpy.core.fromnumeric import prod

def generator(n, choices):
	s = ''
	for i in np.random.choice(choices, n):
		s += i
	return s

def reduction(s):
	table = {
		'AC': 'E',
		'AB': 'BC',
		'BB': 'E',
		'EA': 'A', 'EB': 'B', 'EC': 'C', 'EE': 'E'
	}

	for i in table:
		s = s.replace(i, table[i])
	
	if len(s) != 1:
		reduction(s)

	return s


choices = ['A', 'B', 'C', 'E']

N = 15

s = generator(N, choices)
print(s)
print(reduction('BB'))