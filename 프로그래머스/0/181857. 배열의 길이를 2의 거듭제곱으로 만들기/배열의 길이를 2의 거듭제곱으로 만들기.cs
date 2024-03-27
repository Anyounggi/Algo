using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {

     List<int> list = new List<int>();

     list.AddRange(arr);

 for(int i=2;i<=1024;i*=2) {
     if(arr.Length==1) {
         list.RemoveAll(x => x > 0);
         list.Add(arr[0]);
         break;
     }
     else if(arr.Length==i) 
     {
         break;
     }
     else if (arr.Length < i) {
         for (int s = 0; s < i - arr.Length; s++) {
             list.Add(0);
         }
         break;
     }
 }
        return list.ToArray();
    }
}