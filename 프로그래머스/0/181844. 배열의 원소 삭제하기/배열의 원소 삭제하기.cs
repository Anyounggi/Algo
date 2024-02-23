using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(int[] arr, int[] delete_list) {
        List<int> answer = new List<int>();
        foreach (int num in arr) {
            bool found = false;
            foreach (int del in delete_list) {
                if (num == del) {
                    found = true;
                    break;
                }
            }
            if (!found) {
                answer.Add(num);
            }
        }
        return answer;
    }
}
