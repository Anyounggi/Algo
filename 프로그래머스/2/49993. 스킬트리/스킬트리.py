def solution(skill, skill_trees):
    count = 0
    for skill_tree in skill_trees:
        now = ""
        for s in skill_tree:       
            if s in skill:
                now += s
        
        if skill[:len(now)] == now:
            count += 1
    
    return count