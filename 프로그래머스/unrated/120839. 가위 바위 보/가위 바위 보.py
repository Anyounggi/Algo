def solution(rsps):
    answer = ''
    dict = {"0" : "5", "2" : "0", "5" : "2"}
    for rsp in rsps:
        answer += dict[rsp]
    return answer