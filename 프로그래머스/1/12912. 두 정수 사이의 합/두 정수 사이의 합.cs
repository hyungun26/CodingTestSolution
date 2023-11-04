public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        long big = a > b ? a : b;
        long small = a > b ? b : a;
        for(long i = small;  i <= big; i++)
        {
            answer += i;
        }
        return answer;
    }
}