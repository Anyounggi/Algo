def solution(i, j, k):
    answer = 0
    for num in range(i, j+1):
        for st in str(num):
            if st == str(k):
                answer += 1
    return answer