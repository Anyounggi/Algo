using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        string[] temp = my_string.Split(letter);
        
        for (int i = 0; i < temp.Length; i++) {
            answer += temp[i];
        }
        return answer;
    }
}