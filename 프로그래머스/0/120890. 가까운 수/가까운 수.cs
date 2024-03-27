using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int num = 100;
        Array.Sort(array);
        
        for(int i = 0; i < array.Length; i++)
        {
            if(Math.Abs(array[i] - n) < num)
            {
                num = Math.Abs(array[i] - n);
                answer = array[i];
            }
        }
        return answer;
    }
}