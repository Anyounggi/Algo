using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
        foreach (char s in my_string) {
            if (s.ToString() == alp) {
                answer += s.ToString().ToUpper();
            } else {
                answer += s;
            }
        }
        return answer;
    }
}