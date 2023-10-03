using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b) {
        int answer = 1;
        for(int i = 2; i < b; i++)
        {
            if(a % i == 0 && b % i == 0)
            {
                a = a / i;
                b = b / i;
                i = 2;
            }
        }
        
        List<int> list = new List<int>();
        for(int i = 2; i <= b; i++)
        {
            if(b % i == 0) //소인수는 2와 5만 존재해야한다
            {
                list.Add(i);
            }
        }
        
        foreach(var i in list)
        {
            //Console.Write(i);
        }
        
        for(int i = 0; i < list.Count; i++)
        {
            int count = 0;
            for(int j = 2; j <= b; j++)
            {
                if(list[i] % j == 0)
                {
                    count++;
                    if(count > 1)
                    {
                        list.Remove(list[i]);
                        i = i - 1;
                        break;
                    }
                }
            }
        }
        
        for(int i = 0; i < list.Count; i++)
        {
            if(list[i] == 2 || list[i] == 5)
            {
                
            }
            else
            {
                return 2;
            }
        }
        
       
        return answer;
    }
}