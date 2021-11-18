import random

def miller_rabin(n, k):
    # Implementation uses the Miller-Rabin Primality Test
    # The optimal number of rounds for this test is 40
    # See http://stackoverflow.com/questions/6325576/how-many-iterations-of-rabin-miller-should-i-use-for-cryptographicsafe-primes
    # for justification
    # If number is even, it's a composite number
    if n == 2:
        return True
    if n % 2 == 0:
        return False

    r, s = 0, n - 1
    while s % 2 == 0:
        r += 1
        s //= 2

    for _ in range(k):
        a = random.randrange(2, n - 1)
        x = pow(a, s, n)
        if x == 1 or x == n - 1:
            continue
        for _ in range(r - 1):
            x = pow(x, 2, n)
            if x == n - 1:
                break
            else:
                return False
        return True

def is_prime(n):
    for i in range(2, n):
        if n%i == 0:
            return False
    return True

print(is_prime(153))
print("(153, 5)", miller_rabin(153, 3))
print(is_prime(1147))
print("(1147, 10) = ", miller_rabin(1147, 4))
print(is_prime(738))
print("(7387, 10)", miller_rabin(7387, 5))