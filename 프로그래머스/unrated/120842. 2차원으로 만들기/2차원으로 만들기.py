def solution(num_list, n):
    answer = []
    now = []
    for num in num_list:
        if len(now) == n:
            answer.append(now)
            now = []
        now.append(num)
    if now:
        answer.append(now)
    return answer