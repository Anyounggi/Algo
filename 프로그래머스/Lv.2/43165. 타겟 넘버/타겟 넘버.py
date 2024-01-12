from collections import deque

def solution(numbers, target):
    answer = 0
    Q = deque([(numbers[0], 0), (-numbers[0], 0)])
    
    while Q:
        value, idx = Q.popleft()
        if idx == len(numbers) -1:
            if value == target:
                answer += 1
        else:
            idx += 1
            Q += [(value + numbers[idx], idx), (value - numbers[idx], idx)]
    
    return answer