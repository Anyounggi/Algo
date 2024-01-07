def solution(answers):
    counts = [0, 0, 0]
    ans = [
        [1, 2, 3, 4, 5],
        [2, 1, 2, 3, 2, 4, 2, 5],
        [3, 3, 1, 1, 2, 2, 4, 4, 5, 5]
    ]
    for idx, at in enumerate(ans):
        for i, a in enumerate(answers):
            if a == at[i%len(at)]:
                counts[idx] += 1
    return [i + 1 for i, count in enumerate(counts) if count == max(counts)]