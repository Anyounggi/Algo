def solution(my_string):
    answer = 0
    temp = ""
    for st in my_string:
        if st.isdigit():
            temp += st
        else:
            if temp:
                answer += int(temp)
            temp = ""
    return answer + int(temp) if temp else answer