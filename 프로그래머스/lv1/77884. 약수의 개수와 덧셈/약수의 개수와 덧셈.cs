using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int count = 0;
        
        for(int i = left; i <= right; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                if(i%j == 0)
                {
                    count++;
                }
            }
            Console.Write(count);
            if(count % 2 == 0) //짝수 일때
                answer += i;
            else
                answer -= i;
            count = 0;
        }
        
        return answer;
    }
}