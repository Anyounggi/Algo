using System;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 1;
        foreach (int number in box) {
            answer *= number / n;
        }
        return answer;
    }
}