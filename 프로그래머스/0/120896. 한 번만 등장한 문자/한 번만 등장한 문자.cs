using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in s) {
            if (charCount.ContainsKey(c)) {
                charCount[c]++;
            } else {
                charCount[c] = 1;
            }
        }

        List<char> uniqueChars = new List<char>();

        foreach (KeyValuePair<char, int> entry in charCount) {
            if (entry.Value == 1) {
                uniqueChars.Add(entry.Key);
            }
        }

        uniqueChars.Sort();
        string answer = new string(uniqueChars.ToArray());

        return answer;
    }
}
