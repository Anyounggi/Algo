def solution(babbling):
    answer = 0
    speaks = ["aya", "ye", "woo", "ma"]
    for babb in babbling:
        for speak in speaks:
            if speak * 2 in babb:
                break
            babb = babb.replace(speak, " ")
        
        if not babb.strip():
            answer += 1
    return answer