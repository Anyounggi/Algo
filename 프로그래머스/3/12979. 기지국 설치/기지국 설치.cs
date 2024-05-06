using System;

class Solution {
    public int solution(int n, int[] stations, int w) {
        int answer = 0;
        int i = 0;
        int now = 1;
 
        while (now <= n) {
            if (i < stations.Length && now >= stations[i] - w) {
                now = stations[i] + w + 1;
                i++;
            }
            else {
                now += w * 2 + 1;
                answer++;
            }
        }
 
        return answer;
    }
}