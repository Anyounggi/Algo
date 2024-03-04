using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach (char s in my_string) {
            if (!answer.Contains(s.ToString())) {
                answer += s;
            }
        }
        return answer;
    }
}