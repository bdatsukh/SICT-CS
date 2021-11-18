import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
# Өгөгдөл унших
data = pd.read_csv('data.csv')
X = data.iloc[:, 0]
Y = data.iloc[:, 1]

b1 = 0
b0 = 0
L = 0.0001 # The learning Rate
epochs = 200 # Давталтын тоо
n = float(len(X)) # Өгөгдлийн урт
# Градиентыг бодох
for i in range(epochs):
    Y_pred = b1*X + b0 # The current predicted value of Y
    grad_b1 = (-2/n) * sum(X * (Y - Y_pred)) # b1-ээр авсан уламжлал
    grad_b0 = (-2/n) * sum(Y - Y_pred) # b0-оор авсан уламжлал
    b1 = b1 - L * grad_b1 # b1 -ийн утгыг шинэчлэх
    b0 = b0 - L * grad_b0 # b0 -ын утгыг шинэчлэх

print (b0, b1)
#
Y_pred = b1*X + b0
plt.scatter(X, Y)
plt.plot([min(X), max(X)], [min(Y_pred), max(Y_pred)], color='red') # regression line
plt.show()
