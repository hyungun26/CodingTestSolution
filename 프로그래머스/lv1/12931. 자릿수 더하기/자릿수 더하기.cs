using System;

public class Solution {
    public int solution(int n) {
        int answer = n;
        int g = 1;
        int a = 1;
        int c = 1;
        int b = 0;
            
        while(g > 0)
        {
            g = answer / a;
            if(answer != 0)
            {
                if(a > 100000000)
                {
                    break;
                }
                a *= 10;
            }
            
            c++;
        }
        Console.Write(a);
        for(int i = 0; i < c; i++)
        {
            answer = n / a;
            n -= answer * a;         
            if(a / 10 != 0)
            {
                a /= 10;
            }
            b += answer;
        }
        
        return b;
    }
}