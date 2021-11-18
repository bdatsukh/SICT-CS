from pyfinite import ffield
F = ffield.FField(6)

def toBinary(a):
    return bin(a).replace("0b", "")

def mod(a, b):
    a = format(a, '08b')
    b = format(b, '08b')

    result = ''

    for i in range(len(a)):
        if a[i] == b[i]:
            result += '0'
        else:
            result += '1'

    print(result, int(result, 2))

    return int(result, 2)

# mx = x^2 + x + 1 
# ax = x^2 + 1
# bx = x^2 + x + 1

m = 11
a = 5
b = 7
mx = F.ShowPolynomial(m)
ax = F.ShowPolynomial(a)
bx = F.ShowPolynomial(b)

print(mx)
print(ax)
print(bx)

x = F.Add(a, b)
print('(',ax, ')*(', bx, ')=',F.ShowPolynomial(x))

x = F.Multiply(a, b)

print('(',ax, ')*(', bx, ')=',F.ShowPolynomial(x))  

print(x, m)
x = mod(x, m)
print(x)
print(F.ShowPolynomial(x))