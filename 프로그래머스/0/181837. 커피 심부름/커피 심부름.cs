using System;

public class Solution {
    public int solution(string[] order) {
        
        int sum = 0;
        for(int i=0; i<order.Length; i++) {
            if(order[i].Contains("cafelatte")) {
                sum += 5000;
            }
            else {
                sum += 4500;
            }
        }
        return sum;

    }
}