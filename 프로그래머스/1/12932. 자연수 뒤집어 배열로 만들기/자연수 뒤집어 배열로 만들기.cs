using System;
public class Solution {
    public int[] solution(long n) {
        string s = n.ToString();
        int[] answer = new int[s.Length];
        char[] cArr = s.ToCharArray();
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = (int)cArr[i] % 48;
        }
        Array.Reverse(answer);
        return answer;
    }
}