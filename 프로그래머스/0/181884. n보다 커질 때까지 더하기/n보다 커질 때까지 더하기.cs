using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        int answer = 0;
        int i = 0;
        while (i < numbers.Length && answer <= n) {
            answer += numbers[i];
            i++;
        }
        return answer;
    }
}
