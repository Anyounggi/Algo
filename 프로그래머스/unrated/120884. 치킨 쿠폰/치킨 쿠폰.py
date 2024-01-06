def solution(chicken):
    count = 0
    coupon = chicken
    while coupon >= 10:
        coupon -= 9
        count += 1
    return count