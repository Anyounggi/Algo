using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        foreach (int num in num_list) {
            int currentNum = num;
            while (currentNum != 1) {
                if (currentNum % 2 == 0) {
                    currentNum /= 2;
                } else {
                    currentNum = (currentNum - 1) / 2;
                }
                answer++;
            }
        }
        return answer;
    }
}
