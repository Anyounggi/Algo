def solution(n, s):
    answer = []
    
    if s < n:
        return [-1]
    
    num = s // n
    r = s % n
    
    for i in range(n):
        answer.append(num)
    
    if r:
        for a in range(len(answer)):
            answer[a] += 1
            r -= 1
            if not r:
                break
    
    answer.sort()
    return answer