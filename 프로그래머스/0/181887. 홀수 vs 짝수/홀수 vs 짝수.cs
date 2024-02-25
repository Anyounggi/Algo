using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int[] oe = new int[2];
        for (int i=0; i<num_list.Length; i++) {
            if (i%2==0) {
                oe[0] += num_list[i];
            } else {
                oe[1] += num_list[i];
            }
        }
        answer = Math.Max(oe[0], oe[1]);
        return answer;
    }
}