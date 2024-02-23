using System;

public class Solution {
    public int solution(int a, int b) {
        if(a % 2 == 1 && b % 2 == 1) return (int)(Math.Pow(a, 2) + Math.Pow(b, 2));
        if(a % 2 == 0 && b % 2 == 0) return Math.Abs(a - b);
        return 2 * (a + b);
    }
}
