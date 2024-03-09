using System;

public class Solution {
    public long solution(long n) {
        double x = Math.Sqrt((double)n);
        return x % 1 == 0 ? (long)((x + 1) * (x + 1)) : -1;
    }
}
