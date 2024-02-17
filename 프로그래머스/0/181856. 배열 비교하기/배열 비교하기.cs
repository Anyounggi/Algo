using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        int sum1 = 0;
        int sum2 = 0;
        if (arr1.Length > arr2.Length) {
            sum1 = 1;
        } else if (arr1.Length < arr2.Length) {
            sum2 = 1;
        } else {
            foreach (int i in arr1) sum1 += i;
            foreach (int i in arr2) sum2 += i;
        }
        
        if (sum1 > sum2) {
            answer = 1;
        } else if (sum1 < sum2) {
            answer = -1;
        }
        return answer;
    }
}