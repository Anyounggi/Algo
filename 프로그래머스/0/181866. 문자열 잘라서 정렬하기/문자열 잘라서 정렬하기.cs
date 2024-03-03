using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string myString) {
        
        string[] str = myString.Split("x");
        Array.Sort(str);
        List<string> list = new List<string>();
        for(int i=0; i<str.Length; i++)
        {
            if (str[i]!="")
            {
                list.Add(str[i]);
            }
        }
        return list.ToArray();

    }
}