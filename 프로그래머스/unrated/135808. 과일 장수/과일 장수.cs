using System;
using System.Linq;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        int count = 0;
        int num = 0;
        Array.Sort(score);
        Array.Reverse(score);
        
        for(int i = 0; i < score.Length; i++)
        {
            num = score[i];
            count++;
            
            if(count == m)
            {
                answer += num * m;
                num = 0;
                count = 0;
            }
        };
        
        return answer;
    }
}