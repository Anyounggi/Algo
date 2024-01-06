def solution(A, B):
    chance = len(A)
    
    while chance:
        if A[chance:] + A[:chance] == B:
            return len(A) - chance
        chance -= 1
    return -1