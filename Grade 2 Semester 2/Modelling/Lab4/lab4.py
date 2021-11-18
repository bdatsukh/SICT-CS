import numpy as np
import pandas as pd
import matplotlib.pyplot as plt

data = pd.read_csv('USA_Housing.csv')

x1 = data.iloc[:, 0] # avg. area income
x2 = data.iloc[:, 1] # avg. area house age
x3 = data.iloc[:, 2] # avg. area number of room
x4 = data.iloc[:, 3] # avg. area number of bedroom
x5 = data.iloc[:, 4] # popuplation
y = data.iloc[:, 5] # price

b0 = 0
b1 = 0
b2 = 0
b3 = 0
b4 = 0
b5 = 0

L = 0.0001 # The learning Rate
epochs = 200 # Давталтын тоо

N = float(len(y)) # Өгөгдлийн урт

"""
f(x1, x2, x3, x4, x5) = b + b1*x1 + b2*x2 + b3*x3 + b4*x4 + b5*x5
E(b0, b1, b2, b3, b4, b5) = sum((y - (b0 + b1*x1 + b2*x2 + b3*x3 + b4*x4 + b5*x5))^2) / N
y_pred = (y - (b0 + b1*x1 + b2*x2 + b3*x3 + b4*x4 + b5*x5)
grad_b0 = sum(-2 * (y - y_pred)) / N
grad_b1 = sum(-2 * x1 * (y - y_pred)) / N
grad_b2 = sum(-2 * x2 * (y - y_pred)) / N
grad_b3 = sum(-2 * x3 * (y - y_pred)) / N
grad_b4 = sum(-2 * x4 * (y - y_pred)) / N
grad_b5 = sum(-2 * x5 * (y - y_pred)) / N
"""

for i in range(epochs):
    y_pred = round((b0 + b1*x1 + b2*x2 + b3*x3 + b4*x4 + b5*x5), 10)
    e = y - y_pred
    grad_b0 = round((-2 / N) * sum(e), 10)
    grad_b2 = round((-2 / N) * sum(x2 * e), 10)
    grad_b3 = round((-2 / N) * sum(x3 * e), 10)
    grad_b4 = round((-2 / N) * sum(x4 * e), 10)
    grad_b1 = round((-2 / N) * sum(x1 * e), 10)
    grad_b5 = round((-2 / N) * sum(x5 * e), 10)
    b0 = round(b0 - L * grad_b0, 10)
    b1 = round(b1 - L * grad_b1, 10)
    b2 = round(b2 - L * grad_b2, 10)
    b3 = round(b3 - L * grad_b3, 10)
    b4 = round(b4 - L * grad_b4, 10)
    b5 = round(b5 - L * grad_b5, 10)
    y = y_pred

print (b0, b1, b2, b3, b4, b5)