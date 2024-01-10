def solution(routes):
    routes = sorted(routes, key=lambda x: x[1])
    curr = -30000
    answer = 0
    
    for route in routes:
        if curr < route[0]:
            answer += 1
            curr = route[1]
    return answer