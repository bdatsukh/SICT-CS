import random
from collections import deque

dq = deque()

for i in range(10):
    dq.append(random.randint(0, 10))

print(sorted(dq))
