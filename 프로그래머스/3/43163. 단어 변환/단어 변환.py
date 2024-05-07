from collections import deque


def solution(begin, target, words):
    answer = 0
    Q = deque()
    Q.append([begin, 0])
    V = [0 for i in range(len(words))]
    while Q:
        word, cnt = Q.popleft()
        if word == target:
            answer = cnt
            break        
        for i in range(len(words)):
            now_cnt = 0
            if not V[i]:
                for j in range(len(word)):
                    if word[j] != words[i][j]:
                        now_cnt += 1
                if now_cnt == 1:
                    Q.append([words[i], cnt+1])
                    V[i] = 1
                    
    return answer