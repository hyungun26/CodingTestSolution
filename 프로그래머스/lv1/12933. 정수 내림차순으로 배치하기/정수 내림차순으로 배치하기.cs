using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] cArr = n.ToString().ToCharArray();
        Array.Sort(cArr);
        Array.Reverse(cArr);

        answer = Convert.ToInt64(new string(cArr));
        
        return answer;
    }
}