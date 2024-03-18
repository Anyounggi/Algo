from collections import deque 

def solution(people, limit):
    cnt = 0
    people.sort()
    q = deque(people)
    while len(q) > 1:
        if(q[-1] + q[0] > limit):
            q.pop()
            cnt += 1
        else:
            q.popleft()
            q.pop()
            cnt += 1
        
    cnt += len(q)
    return cnt