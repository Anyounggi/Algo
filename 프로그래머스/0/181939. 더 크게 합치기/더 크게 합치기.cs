using System;

public class Solution {
    public int solution(int a, int b) {
        string sumAB = a.ToString() + b.ToString();
        string sumBA = b.ToString() + a.ToString();
        
        int AB = int.Parse(sumAB);
        int BA = int.Parse(sumBA);
        
        if(AB > BA){
            return AB;
        } else if( AB < BA){
            return BA;
        } else return AB;
    }
}