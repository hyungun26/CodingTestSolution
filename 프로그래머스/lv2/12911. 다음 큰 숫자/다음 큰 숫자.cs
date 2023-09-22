using System;

class Solution 
{
    public int solution(int n) 
   {
        bool check = false;
        int answer = 0;
        string str = Convert.ToString(n, 2);
        int countN = 0;
        for(int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if(c == '1')
            {
                countN++;
            }
        }
        
        while(!check)
        {
            string str2 = Convert.ToString(n+1, 2);
            int countN2 = 0;
            for(int i = 0; i < str2.Length; i++)
            {
                char c = str2[i];
                if(c == '1')
                {
                    countN2++;
                }
            }
            
            if(countN == countN2)
            {
                answer = Convert.ToInt32(str2, 2);
                check = true;
                break;
            }
            n++;
        }
        
        return answer;
    }
}