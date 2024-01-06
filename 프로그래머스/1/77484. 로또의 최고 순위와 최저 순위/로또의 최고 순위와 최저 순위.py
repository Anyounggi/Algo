def solution(lottos, win_nums):
    unk = 0
    win = 0
    for num in lottos:
        if not num:
            unk += 1
        elif num in win_nums:
            win += 1
            
    stand = [6, 6, 5, 4, 3, 2 ,1]
    return [stand[win+unk], stand[win]]