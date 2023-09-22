using System;

public class Solution {
    public bool solution(string s) {
        bool answer = false;
        int a = 0;
        int c = 0;
        char[] arr = s.ToCharArray();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(arr[i] == '(')
            {
                a++;
            }
            else if(arr[i] == ')')
            {
                a--;
            }
            
            if(a < 0)
                return answer = false;
        }
        
        if(a != 0)
            return answer = false;
        
        return answer = true;
    }
}