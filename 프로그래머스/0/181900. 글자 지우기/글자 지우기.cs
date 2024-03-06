using System;

public class Solution
{
    public string solution(string my_string, int[] indices)
    {
        char[] chars = my_string.ToCharArray();
        for (int i = 0; i < indices.Length; i++)
        {
            int Idx = indices[i];
            chars[Idx] = ' ';
        }

        return new string(chars).Replace(" ", "");
    }
}