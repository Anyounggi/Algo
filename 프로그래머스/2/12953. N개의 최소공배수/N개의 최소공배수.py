from math import gcd

def lcm(x, y):
    return x * y // gcd(x, y)

def solution(arr):
    answer = arr[0]
    for n in arr:
        answer = lcm(n, answer)
    return answer
