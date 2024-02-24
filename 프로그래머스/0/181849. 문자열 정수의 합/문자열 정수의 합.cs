using System;

public class Solution {
    public int solution(string num_str) {
        int answer = 0;
        foreach (char num in num_str) {
            answer += Int32.Parse(num.ToString());
        }
        return answer;
    }
}
