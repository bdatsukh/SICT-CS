import numpy as np
import matplotlib.pyplot as plt
import pandas as pd
import math

def fact(n):
    prod = 1
    for i in range(2, n + 1):
        prod *= i
    return prod

mu = 3
x = []

for i in range(100):
    u = np.random.uniform(0, 1)
    x.append(-mu * math.log(1 - u))
    x.append((mu**i * math.e**(-mu)) / fact(i))

df = pd.DataFrame(data=x)
df.hist()
plt.show()
