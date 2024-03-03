using System;

public class Solution {
    public int solution(string number) {
        int sum = 0;
        foreach (char digit in number) {
            sum += digit - '0';
        }
        return sum % 9;
    }
}
