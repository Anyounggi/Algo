using System;

public class Solution {
    public string solution(string n_str) {
        string answer = "";
        for (int i = 0; i < n_str.Length; i++) {
            if (n_str[i] != '0') {
                answer = n_str.Substring(i, n_str.Length - i);
                break;
            }
        }
        return answer;
    }
}
