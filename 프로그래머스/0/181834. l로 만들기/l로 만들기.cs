using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        foreach (char s in myString) {
            if (s < 'l') {
                answer += 'l';
            } else {
                answer += s;
            }
        }
        return answer;
    }
}