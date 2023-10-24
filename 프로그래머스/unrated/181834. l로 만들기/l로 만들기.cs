using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        char[] cArr = myString.ToCharArray();
        for(int i = 0; i < cArr.Length; i++)
        {
            if(cArr[i] < 'l')
                cArr[i] = 'l';
            answer += cArr[i];
        }
        return answer;
    }
}