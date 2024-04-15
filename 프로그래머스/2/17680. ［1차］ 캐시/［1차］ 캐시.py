from collections import deque

def solution(cacheSize, cities):
    answer = 0
    
    cache = deque()
    cache_set = set()
    
    if not cacheSize:
        return len(cities) * 5
    
    for city in cities:
        city_up = city.upper()
        if city_up in cache_set:
            cache.remove(city_up)
            answer += 1
        else:
            answer += 5
            if len(cache) >= cacheSize:
                removed_city = cache.popleft()
                cache_set.remove(removed_city)
                
        cache.append(city_up)
        cache_set.add(city_up)
        
    return answer
