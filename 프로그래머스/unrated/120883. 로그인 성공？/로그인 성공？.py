def solution(id_pw, db):
    wrong = False
    for id, pw in db:
        if id == id_pw[0]:
            wrong = True
            
            if pw == id_pw[1]:
                return "login"
    return "wrong pw" if wrong else "fail"