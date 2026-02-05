# for i in range(0, 1001):
#     print(i)


def isPrime(n):
    if n < 2:
        return False
    for i in range(2, int(n ** 0.5) + 1):
        if n % i == 0:
            return False
    return True


def fiboWithLim(limit):
    fibo = []
    a, b = 0, 1
    while b < limit:
        fibo.append(b)
        a, b = b, a + b
    return fibo

limit = 1000
fibonacciNumbers = fiboWithLim(limit)

primeFibonacci = [n for n in fibonacciNumbers if isPrime(n)]

print("Prime and Fibonacci numbers below 1000:", primeFibonacci)
print("Count:", len(primeFibonacci))
