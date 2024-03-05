using System;

public class Solution {
    public int solution(int a, int d, bool[] included) {
        int n = included.Length;
        int answer = 0;
        for  (int i=0; i<n; i++) {
            if (included[i]) {
                answer += (a+d*i);
            }
        }
        return answer;
    }
}