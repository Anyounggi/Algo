using System;

public class Solution {
    public int solution(int[,] arr) {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (arr[i, j] != arr[j, i])
                    return 0;
            }
        }
        return 1;
    }
}
