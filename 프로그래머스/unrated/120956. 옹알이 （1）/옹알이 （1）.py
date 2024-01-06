def solution(babbling):
    answer = 0
    words = ["aya", "ye", "woo", "ma"]
    for babb in babbling:
        for word in words:
            babb = babb.replace(word, " ")
        if not babb.strip():
            answer += 1
    return answer