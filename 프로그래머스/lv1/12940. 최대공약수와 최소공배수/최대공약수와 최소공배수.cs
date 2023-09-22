using System;
public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        
        int Max = (n > m) ? n : m;
        int Min = (n < m) ? n : m;
        
        int a = 0;
        
        for(int i = 1; i < Max; i++)
        {
            if(n % i == 0 && m % i == 0)
            {
                if(a < i)
                    a = i;
            }
        }
        
        int Mx = Max;
        int Mn = Min;
        
        while(Max != Min)
        {
            if(Max > Min)
            {
                Min += Mn;    
            }
            else if(Max < Min)
            {
                Max += Mx;
            }
        }
        
        
        answer[0] = a;
        answer[1] = Max;
        
        return answer;
    }
}