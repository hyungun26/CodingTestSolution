using System;

public class Solution {
    public string solution(string myString, string pat) {
        string answer = "";
        for(int i = 0; i < myString.Length; i++)
        {
            string s = myString.Substring(myString.Length - pat.Length - i, pat.Length);
            if(s == pat)
            {
                answer = myString.Substring(0, myString.Length - i);
                break;
            }
        }
        return answer;
    }
}