import random
import math
import matplotlib.pyplot as plt

t=[]
y=[]

def buffon(n,r,l,a):
    for k in range(r):
        total = 0
        n=n+500*k
        
        for _i in range(n):
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

r=100
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

#%%
# %%
