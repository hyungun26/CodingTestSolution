using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        string s = "";
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i].ToString();
        }
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '7')
                answer++;
        }
        return answer;
    }
}