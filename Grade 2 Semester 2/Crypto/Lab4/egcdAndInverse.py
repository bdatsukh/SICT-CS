
def gcdExtended(a, b, x, y):
    # Base Case
    if a == 0:
        x = 0
        y = 1
        return b
    x1 = 1
    y1 = 1 # To store results of recursive call
    gcd = gcdExtended(b%a, a, x1, y1)
    # Update x and y using results of recursive
    # call
    x = y1 - (b/a) * x1
    y = x1
    return gcd 


a = 1759        
b = 550
x = 1
y = 1

print("gcde: ", gcdExtended(a, b, x, y))


