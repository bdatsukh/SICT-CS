def gcd(a, b):
    counter = 0
    while(b):
        a, b = b, a % b
        counter += 1
    return a, counter

a = 123123
b = 123123123

g, cnt = gcd(a, b)

print("gcd(", a, ",", b, ") = ", g, "counter: ", cnt)

a = 978
b = 89798763754892653453379597352537489494736

g, cnt = gcd(a, b)

print("gcd(", a, ",", b, ") = ", g, "counter: ", cnt)

a = 1221
b = 1234567891011121314151617181920212223242526272829

g, cnt = gcd(a, b)

print("gcd(", a, ",", b, ") = ", g, "counter: ", cnt)
