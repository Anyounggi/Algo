def solution(my_string):
    ans = 0
    oper = ""
    for st in my_string.split():
        if st in ["+", "-"]:
            oper = st
        else:
            if oper == "+":
                ans += int(st)
            elif oper == "-":
                ans -= int(st)
            else:
                ans = int(st)
    return ans