using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        int num = 0;
        
        for(int i = 0; i < myString.Length - pat.Length+1; i++)
        {
            int a = 0;
            if(myString[i] == pat[0])
            {
                for(int j = 0; j < pat.Length; j++)
                {
                    if(myString[i+j] == pat[j])
                    {
                        a++;
                        if(a == pat.Length)
                        {
                            answer++;
                        }
                    }
                }
            }
        }
        return answer;
    }
}