using System;

public class Solution {
    public int solution(int[,] board, int k) {
        int answer = 0;
        int rowCount = board.GetLength(0);
        int colCount = board.GetLength(1);
        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < colCount; j++) {
                if (i + j <= k) {
                    answer += board[i, j];
                }
            }
        }
        return answer;
    }
}
