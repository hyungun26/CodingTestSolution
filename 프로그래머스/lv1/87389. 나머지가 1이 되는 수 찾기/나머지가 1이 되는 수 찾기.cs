using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        
        
        for(int i = 1; i < n; i++)
        {
            answer = n % i; //n의 나머지 값을 정함
            if(answer == 1)
            {
                return answer = i;
            }
        }
        
        return answer;
    }
}