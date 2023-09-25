using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string sa = a.ToString();
        string sb = b.ToString();
        a = Int32.Parse(sa+sb);
        int num = 2 * Int32.Parse(sa) * Int32.Parse(sb);
        answer = a > num ? a : num;
        return answer;
    }
}