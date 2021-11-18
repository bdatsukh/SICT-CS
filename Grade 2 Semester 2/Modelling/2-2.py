import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

a = 0
b = 1
t = []
z = []

def normal_function(x):
    return x*x

X = np.linspace(a, b, 1000)
plt.plot(X,normal_function(X))
plt.show()

def integrate(x1,x2,func=normal_function,n=1000000):
    X = np.linspace(x1, x2, n)
    area = 0.0
    for i in range(n - 1):
        u = np.random.uniform(0, 1)
        a=X[i] + u * (X[i+1] - X[i])
        area = area + func(a)
    
    return((x2 - x1) / n * area)

r = 100
n = 10

for k in range(r):
    count = 10 + 50 * k
    s = integrate(a, b, n = count)
    print (str(k),str(s),sep = '      ')
    t.append(k)
    z.append(s)

plt.plot(t, z) 
plt.xlabel('x - axis') 
plt.ylabel('y - axis') 
plt.title('Интерал') 
plt.show()