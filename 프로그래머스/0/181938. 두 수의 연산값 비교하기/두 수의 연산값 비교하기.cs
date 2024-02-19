using System;

public class Solution {
    public int solution(int a, int b) {
        int num1 = int.Parse(a.ToString() + b.ToString());
        int num2 = 2 * a * b;
        return num1 > num2 ? num1 : num2;
    }
}
