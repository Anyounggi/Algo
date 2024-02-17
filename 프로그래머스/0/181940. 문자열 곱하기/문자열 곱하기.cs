using System;

public class Solution {
    public string solution(string my_string, int k) {
        string answer = "";
        int i = 0;
        while (i<k) {
            answer += my_string;
            i++;
        }
        return answer;
    }
}