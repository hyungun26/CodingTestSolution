using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int odd = 0;
        int even = 0;
        
        for(int i = 1; i < n+1; i++)
        {
            if(i % 2 == 0)
                even += i*i;
            else
                odd += i;
            
        }
        
        answer = n % 2 == 0 ? even : odd;
        return answer;
    }
}