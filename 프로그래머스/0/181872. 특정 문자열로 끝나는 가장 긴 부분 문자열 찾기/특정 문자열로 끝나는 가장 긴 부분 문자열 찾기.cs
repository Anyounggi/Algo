using System;

public class Solution {
    public string solution(string myString, string pat) {
        int lastIdx = myString.LastIndexOf(pat);
        return myString.Substring(0, lastIdx) + pat;
    }
}