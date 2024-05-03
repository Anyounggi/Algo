def solution(stones, k):
    s = 1
    e = max(stones) + 1
    while s <= e:
        mid = (s + e) // 2
        cnt = 0
        for t in stones:
            if t - mid <= 0:
                cnt += 1
            else:
                cnt = 0
            if cnt >= k:
                break
        if cnt >= k:
            e = mid - 1
        else:
            s = mid + 1
        
    return s