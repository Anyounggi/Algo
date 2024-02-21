using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length];
        for (int i=0; i<num_list.Length-n; i++) {
            answer[i] = num_list[i+n];
        }
        for (int i=0; i<n; i++) {
            answer[num_list.Length-n+i] = num_list[i];
        }
        return answer;
    }
}