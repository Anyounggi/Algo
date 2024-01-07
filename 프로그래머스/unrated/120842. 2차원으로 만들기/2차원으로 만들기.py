def solution(num_list, n):
    answer = []
    now = []
    for num in num_list:
        now.append(num)
        if len(now) == n:
            answer.append(now)
            now = []
    return answer