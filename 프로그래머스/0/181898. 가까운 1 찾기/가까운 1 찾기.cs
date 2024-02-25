using System;

public class Solution {
    public int solution(int[] arr, int idx) {
         while (arr.Length>idx)
            {
                if (arr[idx] == 1)
                    return idx;
                idx++;
            }
            return -1;
        
           int index = 0;
            return Array.FindIndex(arr,x => index++ >=idx && x == 1);
    }
}