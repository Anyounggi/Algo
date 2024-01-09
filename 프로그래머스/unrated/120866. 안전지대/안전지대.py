def solution(board):
    n = len(board)
    danger = set()
    for i, row in enumerate(board):
        for j, x in enumerate(row):
            if x:
                danger.update(
                    (i + di, j + dj)
                    for di in [-1, 0, 1]
                    for dj in [-1, 0, 1]
                    if 0 <= i + di < n and 0 <= j + dj < n
                )
    return n * n - len(danger)