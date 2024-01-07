def solution(my_str, n):
    answer = []
    now = 0
    now_str = ""
    for st in my_str:
        if now < n:
            now_str += st
            now += 1
        else:
            answer.append(now_str)
            now_str = st
            now = 1
    answer.append(now_str)
    return answer