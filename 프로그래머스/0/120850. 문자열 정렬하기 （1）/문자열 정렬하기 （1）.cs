using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string my_string) {
        if (my_string.Length < 1 || my_string.Length > 100)
            throw new Exception("1 ≤ my_string의 길이 ≤ 100");

        var numbers = my_string.Where(char.IsDigit).Select(x => int.Parse(x.ToString())).ToArray();
        Array.Sort(numbers);
        return numbers;
    }
}
