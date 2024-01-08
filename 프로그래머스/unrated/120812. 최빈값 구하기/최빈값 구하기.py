def solution(array):
    while array:
        for idx, val in enumerate(set(array)):
            array.remove(val)
        if not idx:
            return val
    return -1