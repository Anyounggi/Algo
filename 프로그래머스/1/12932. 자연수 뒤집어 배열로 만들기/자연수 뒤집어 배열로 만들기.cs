public class Solution {
    public int[] solution(long n) {
        string numString = n.ToString();
        int[] answer = new int[numString.Length];
        int index = 0;

        while (n > 0) {
            answer[index] = (int)(n % 10);
            n = n / 10;
            index++;
        }

        return answer;
    }
}
