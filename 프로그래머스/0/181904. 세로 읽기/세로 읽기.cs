using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string my_string, int m, int c) {
       string answer = "";

            for (int i = 0; i < my_string.Length/m; i++) {
                string s = my_string.Substring(i * m, m);
                answer+= s[c - 1];
            }
            return answer;
    }
}