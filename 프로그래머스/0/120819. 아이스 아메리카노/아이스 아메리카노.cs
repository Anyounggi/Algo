using System;

public class Solution {
    public int[] solution(int money) {
        int[] answer = new int[2] {money / 5500, money % 5500};
        return answer;
    }
}