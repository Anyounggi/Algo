def solution(array):
    answer = 0
    for num in array:
        for st in str(num):
            if st == "7":
                answer += 1
    return answer