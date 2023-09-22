using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int a = 0;
        for(int i = 1; i < n+1; i++)
        {
            answer = n % i;
            if(answer == 0)
            {
                a += i;
            }
        }
        
        
        return a;
    }
}