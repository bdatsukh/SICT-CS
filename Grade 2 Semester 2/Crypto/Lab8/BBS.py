p = 383
q = 503
n = p * q
s = 101355
x = []
x.append((s ** 2) % n)

for i in range(1, 21):
    x.append((x[i - 1]**2) % n)

print(x)