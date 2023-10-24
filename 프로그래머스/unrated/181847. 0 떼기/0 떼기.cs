using System;

public class Solution {
    public string solution(string n_str) {
        string answer = "";
        char[] cArr = n_str.ToCharArray();
        bool check = false;
        for(int i = 0; i < n_str.Length; i++)
        {
            if(cArr[i] == '0' && !check)
            {
                cArr[i] = ' ';
            }
            else 
            {
                check = true;
            }
            answer += cArr[i];
        }
        answer = answer.Replace(" ", "");
        return answer;
    }
}