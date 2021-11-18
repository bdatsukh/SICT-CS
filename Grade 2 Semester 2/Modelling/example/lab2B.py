import random
import math
import matplotlib.pyplot as plt

t=[]
y=[]

def buffon(n,r,l,a):
    data=[]

    for k in range(r):
        total = 0
        n=n+500*k

        for i in range(n):
            x = random.uniform(0,a)
            theta = random.uniform(0,math.pi)
            x = x - l*math.sin(theta)
    
            if x < 0 :
                total += 1 #Огтолж байгаа тоо

        c = 2.0*l*n
        d = a*total
        print (str(k)+' '+str(c/d))
        t.append(k)
        y.append(c/d)

r=50
n=4000
l = 2 #зүүний урт
a= 2 #шулууны хоорондын зай

print ("Туршилтын тоо pi тооны үнэлгээ")

buffon(n,r,l,a)

plt.plot(t, y)
plt.xlabel('x - axis')
plt.ylabel('y - axis')
plt.title('Pi тооны үнэлгээ')
plt.show() 
"""
import random 
import math
import matplotlib.pyplot as plt

a = 100
l = 50

it = 10000

result = []

for i in range(1000, it + 1, 100):
    m = 0
    n = i

    for j in range(i):
        x = random.uniform(0, a)
        y = random.uniform(0, math.pi)

        if(x <= l*math.sin(y)):
            m += 1
        
    pi = (2 * l / a) * (n / m)
    result.append(pi)
        
plt.plot(range(1000, it + 1, 100), result)
plt.title('Бюффоны зүү')
plt.show()
"""