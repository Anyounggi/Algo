using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = (int[])arr.Clone();
        for (int i = 0; i < queries.GetLength(0); i++) {
            int startIdx = Math.Max(0, queries[i, 0]);
            int endIdx = Math.Min(arr.Length - 1, queries[i, 1]);
            for (int j = startIdx; j <= endIdx; j++) {
                answer[j]++;
            }
        }
        return answer;
    }
}
