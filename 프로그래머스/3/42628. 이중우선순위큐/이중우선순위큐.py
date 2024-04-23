import heapq

def solution(operations):
    heap = []
    
    for o in operations:
        op, num = o.split()
        if op == 'I':
            heapq.heappush(heap, int(num))
        elif heap:
            if num == '1':
                heap.remove(max(heap))
            else:
                heapq.heappop(heap)

    if heap:
        return [max(heap), heapq.heappop(heap)]
    else:
        return [0, 0]
