def solution(priorities, location):
    que = list(enumerate(priorities))
    answer = 0
    while que:
        cur = que.pop(0)
        if any(cur[1] < q[1] for q in que):
            que.append(cur)
        else:
            answer += 1
            if cur[0] == location:
                return answer