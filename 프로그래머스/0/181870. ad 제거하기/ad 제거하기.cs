using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr) {
        List<string> answer = new List<string>();
        foreach (string strEl in strArr) {
            if (!strEl.Contains("ad")) {
                answer.Add(strEl);
            }
        }
        return answer.ToArray();
    }
}