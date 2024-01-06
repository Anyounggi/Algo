def solution(quizzes):
    answer = []
    for quiz in quizzes:
        left, right = quiz.split(" = ")
        num1, oper, num2 = left.split()
        if oper == "+":
            if int(num1) + int(num2) == int(right):
                answer.append("O")
            else:
                answer.append("X")
        else:
            if int(num1) - int(num2) == int(right):
                answer.append("O")
            else:
                answer.append("X")
    return answer