using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        List<char> b = new List<char> { };
        List<char> a = new List<char> { };
        foreach (char j in before) {
            b.Add(j);
            b.Sort();
        }
        foreach (char j in after) {
            a.Add(j);
            a.Sort();
        }
        string b1 = string.Join("", b);
        string a1 = string.Join("", a);
        if (b1 == a1) {
            answer = 1;
        } else {
            answer = 0;
        }
    return answer;
    }
}