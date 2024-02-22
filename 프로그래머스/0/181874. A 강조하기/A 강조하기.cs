using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        foreach (char s in myString){
            if (s.ToString() == "A" || s.ToString() == "a") {
                answer += "A";
            } else {
                answer += s.ToString().ToLower();
            }
        } 
        return answer;
    }
}