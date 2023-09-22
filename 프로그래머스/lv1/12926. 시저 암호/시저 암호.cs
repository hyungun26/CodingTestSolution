using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        char[] cArr = s.ToCharArray();
        
        for(int i = 0 ; i < s.Length; i++)
        {
            int num = (int)cArr[i] + n;
            
            if((int)cArr[i] >=65 && 90 >= (int)cArr[i] && num > 90)
            {
                num = num - 26;
            }
            
            if((int)cArr[i] >=97 && 122 >= (int)cArr[i] && num > 122)
            {
                num = num- 26;
            }
            
            char c = (char)num;
            
            if((int)c == 32+n)
            {
                num = 32;
            }
            
            answer += (char)num;
        }
        
        return answer;
    }
}