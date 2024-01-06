def solution(s):
    answer = 0
    n = 0
    m = 0
    for st in s:
        if n == m:
            answer += 1
            pre = st
        if st == pre:
            n += 1
        else:
            m += 1
            
    return answer