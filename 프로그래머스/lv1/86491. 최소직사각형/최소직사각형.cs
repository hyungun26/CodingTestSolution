using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int big = 0;
        int small = 0;
        for(int i = 0; i < sizes.Length * 0.5; i++)
        {
            if(sizes[i,1] > sizes[i,0])
            {
                int swap = sizes[i,0];
                sizes[i,0] = sizes[i,1];
                sizes[i,1] = swap;
            }
        }
        
        for(int i = 0; i < sizes.Length * 0.5; i++)
        {
            if(sizes[i,0] > big)
            {
                big = sizes[i,0];
            }
            if(sizes[i,1] > small)
            {
                small = sizes[i,1];
            }
        }
        
        answer = big * small;
        
        return answer;
    }
}