import math
import random
import matplotlib.pyplot as plt

n = 1000
result = []

for i in range(n):
    x = random.uniform(0, n)
    total = ((math.sqrt(math.pi) * math.erf(x / math.sqrt(2))) / math.sqrt(2) + random.random()) / 2
    print(total)
    result.append(total)

plt.plot(result)
plt.show()






























'''
import math 
import random
import matplotlib.pyplot as plt

n = 2000

hits = 0

a = []
b = []
for i in range(1, n):
    hits = 0

    for j in range(i):
        x = random.random()
        y = random.random()

        distance = math.sqrt(x * x + y * y)
        
        if distance <= 1: 
            hits += 1

    a.append(i)
    b.append((hits / i) * 4)
    
plt.axhline(y=3.14159, color='r')
plt.plot(a, b)
plt.xlabel('Turshiltiin too')
plt.ylabel('Magadlal')
plt.title('Pi toonii unelelt')
plt.show()
'''