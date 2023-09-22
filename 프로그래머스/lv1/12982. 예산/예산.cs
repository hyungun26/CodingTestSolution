using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        int num = 0;
        Array.Sort(d);
        
        for(int i = 0 ; i < d.Length; i++)
        {
            num += d[i];
            if(num <= budget)
            {
                answer++;
            }
        }
        
        return answer;
    }
}