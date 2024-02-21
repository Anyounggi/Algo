using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        string newString = "";
        foreach (char s in myString) {
            if (s.ToString() == "A") {
                newString += "B";
            } else if (s.ToString() == "B") {
                newString += "A";
            }
        }
        if (newString.Contains(pat)) {
            answer = 1;
        }
        return answer;
    }
}