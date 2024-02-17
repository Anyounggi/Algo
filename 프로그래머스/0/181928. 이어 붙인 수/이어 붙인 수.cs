using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int first = 0;
        int second = 0;

        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] % 2 == 0)
                first = (int)(10 * first) + (num_list[i]);
            else
                second = (int)(10 * second) + (num_list[i]);
        }
        return first + second;
    }
}