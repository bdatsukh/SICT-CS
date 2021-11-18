import numpy as np
import random
import matplotlib.pyplot as plt

def fx(x1, x2, x3):
    return 2 * x1 ** 2 + 3 * x2 ** 3 - 4 * x3 ** 2
'''
def pso(particle, c1, c2, w, bounds, it):



    for i in range(it):
        '''
xlist = np.linspace(-10.0, 10.0, 100)
ylist = np.linspace(-10.0, 10.0, 100)
X, Y = np.meshgrid(xlist, ylist)
Z = np.sqrt(X**2 + Y**2)
fig,ax=plt.subplots(1,1)
cp = ax.contourf(X, Y, Z)
fig.colorbar(cp) # Add a colorbar to a plot
ax.set_title('Filled Contours Plot')
#ax.set_xlabel('x (cm)')
ax.set_ylabel('y (cm)')
plt.show()

'''

particle = 6
c1 = 2
c2 = 2
w = (0.9, 0.4)
bounds = (-10, 10)
it = 1000
#fx = 2 * x1 ^ 2 + 3 * x2 ^ 3 - 4 * x3 ^ 2 

pso(particle, c1, c2, w, bounds, it)
'''