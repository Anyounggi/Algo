using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = 0;
        string numToStr = num.ToString();
        
        if(numToStr.Contains(k.ToString())) {
            answer = numToStr.IndexOf(k.ToString()) + 1;
        }
        else {
            answer = -1;
        }
        
        return answer;
    }
}