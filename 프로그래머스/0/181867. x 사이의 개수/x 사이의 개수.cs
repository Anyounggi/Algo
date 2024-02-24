using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string myString) {
        List<int> lengths = new List<int>();
        int currentLength = 0;

        foreach (char ch in myString) {
            if (ch == 'x') {
                lengths.Add(currentLength);
                currentLength = 0;
            } else {
                currentLength++;
            }
        }

        lengths.Add(currentLength);

        return lengths.ToArray();
    }
}
