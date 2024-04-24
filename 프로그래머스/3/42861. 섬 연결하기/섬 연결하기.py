def solution(n, costs):
    answer = 0
    costs.sort(key = lambda x: x[2]) 
    l = set([costs[0][0]])

    while len(l) != n:
        for v in costs:
            if v[0] in l and v[1] in l:
                continue
            if v[0] in l or v[1] in l:
                l.update([v[0], v[1]])
                answer += v[2]
                break
                
    return answer