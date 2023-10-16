using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        char[] cArr = s.ToCharArray();
        char[] skipCArr = skip.ToCharArray();
        Array.Sort(skipCArr);
        int num = index;
        
        for(int i = 0; i < cArr.Length; i++)
        {
            int count = 0;
            for(int j = 0; j < skipCArr.Length; j++)
            {
                if(cArr[i] <= skipCArr[j] && cArr[i]+num >= skipCArr[j])
                {
                    cArr[i] = (char)((int)cArr[i]+1);
                    count++;
                }   
            }
            
            if(cArr[i]+num > 122)
            {
                num = cArr[i]+num - (int)'{';
                cArr[i] = 'a';
                i--;
                continue;
            }
            answer += (char)((int)cArr[i]+num);
            num = index;
        }
        return answer;
    }
}