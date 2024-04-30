public class Solution {
    public string solution(string s) {
        int num = s.Length;
        if (num % 2 == 0) {
            return s.Substring(num / 2 - 1, 2);
        } else {
            return s.Substring(num / 2, 1);
        }
    }
}
