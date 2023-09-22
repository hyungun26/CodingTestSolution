using System;

public class Solution {
    public long solution(int n) {
        long answer = 0;
        int num = 1;
        int count = 0;
        int a = 0;
        
        while(n >= num)
        {
            count++;
            num *= 3;
        }
        
        if(n == 1)
        {
            return answer = 1;
        }
        else
        {
            num /= 3;
        }
        
        int[] num3 = new int[count];
        
        for(int i = 0; i < num3.Length; i++)
        {
            if(n / num == 1)
            {
                num3[i] = 1;
                n = n - num;
            }
            else if(n / num == 2)
            {
                num3[i] = 2;
                n = n - num*2;
            }
                
            num /= 3;
            
            if(n == 0)
            {
                break;
            }
        }
        
        num = 1;
        
        for(int i = 0; i < num3.Length; i++)
        {
            answer += num * num3[i];
            num *= 3;
        }
        
        return answer;
    }
}