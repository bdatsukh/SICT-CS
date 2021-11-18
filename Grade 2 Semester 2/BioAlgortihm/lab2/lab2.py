import random
import matplotlib.pyplot as plt
import math

it = 100000
yIt = []

side = 10
r = side / 2

result = 0

for i in range(1, it + 1):
    x = random.uniform(- side / 2, side / 2)
    y = random.uniform(- side / 2, side / 2)
    distance = math.sqrt(x ** 2 + y ** 2)

    if r >= distance:
        result += 1
    if i >= 10000:
        areaTriangle = (result / i) * side ** 2
        pi = areaTriangle / r ** 2
        yIt.append(pi)

plt.plot(range(10000, it + 1), yIt)
plt.show()