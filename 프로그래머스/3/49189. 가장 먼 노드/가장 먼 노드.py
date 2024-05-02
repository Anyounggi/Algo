from collections import deque

def solution(n, edge):
    answer = 0
    graph =[[] for _ in range(n+1)]
    distance = [-1] * (n + 1)
    
    for e in edge:
        graph[e[0]].append(e[1])
        graph[e[1]].append(e[0])  
    
    Q = deque([1])
    distance[1] = 0
    
    while Q:
        now = Q.popleft()
        for i in graph[now]:
            if distance[i] == -1:
                Q.append(i)
                distance[i] = distance[now] + 1
    for dis in distance:
        if dis == max(distance):
            answer += 1
    return answer