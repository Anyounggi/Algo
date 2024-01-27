def solution(s):
    answer = ''
    lst = list(map(int, s.split()))
    answer += str(min(lst)) + ' '
    answer += str(max(lst))
    return answer