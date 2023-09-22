using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long answer = 0;    
        long num = 0;
        for(int i = 0; i < count; i++)
        {
            answer = answer + price;
            num += answer;
        }
        
        num = num - money;
        if(num < 0)
        {
            num = 0;
        }
        return num;
    }
}