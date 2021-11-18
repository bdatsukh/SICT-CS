x = []
x.append(1)
n = 5
a = 7
c = 0
m = 32

for i in range(n + 1):
    x.append((a * x[i] + c) % m)

print(x)