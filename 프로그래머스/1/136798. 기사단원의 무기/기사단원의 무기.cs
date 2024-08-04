using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int a = 0;
        for(int i = 1; i <= number; i++) //이건 무적권해야함
        {
            int num = 0;
            for(int j = 1; j <= i; j++)
            {
                if(i % j == 0)
                {
                    num++;   
                    if(num > limit)
                    {
                        num = power;
                        break;
                    }
                    if(a * j == i)
                    {
                        num = (num-1) * 2;
                        if(num > limit)
                        {
                            num = power;
                        }
                        break;
                    }
                    a = j;
                }   
            }
            answer += num;
        }
        return answer;
    }
}