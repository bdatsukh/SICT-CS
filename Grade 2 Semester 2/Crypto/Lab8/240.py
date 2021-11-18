import random

def prng(n, a, c, m):    
    x = [random.randint(0, m)]
    for i in range(n + 1):
        x.append((a * x[i] + c) % m)
    return x

print("x_n+1 = (6*x_n)%13: " + str(prng(14, 6, 0, 13)))
print("x_n+1 = (7*x_n)%13: " + str(prng(14, 7, 0, 13)))