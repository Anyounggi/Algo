using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
        List<int> list = new List<int>();
        foreach (var it in my_string)
        {
            if (int.TryParse(it.ToString(), out var value))
            {
                list.Add(value);
            }
        }

        list.Sort();
        return list.ToArray();
    }
}