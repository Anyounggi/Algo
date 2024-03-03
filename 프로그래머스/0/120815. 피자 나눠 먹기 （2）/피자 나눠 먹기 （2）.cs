using System;

public class Solution {
    public int solution(int n) {
        int answer = n;
        while (n%6!=0) {
            n+=answer;
        }
        return n/6;
    }
}