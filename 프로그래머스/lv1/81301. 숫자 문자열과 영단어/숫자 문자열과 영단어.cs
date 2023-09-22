using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        char[] cArr = s.ToCharArray();
        string answerS = "";
        string str = "";
        for(int i = 0; i < s.Length; i++)
        {
            str += cArr[i];
            switch(str)
            {
                case "zero": str = "0";
                    break;
                case "one": str = "1";
                    break;
                case "two": str = "2";
                    break;
                case "three": str = "3";
                    break;
                case "four": str = "4";
                    break;
                case "five": str = "5";
                    break;
                case "six": str = "6";
                    break;
                case "seven": str = "7";
                    break;
                case "eight": str = "8";
                    break;
                case "nine": str = "9";
                    break;
                default : str = str;
                    break;
            }
            if(int.TryParse(str, out int j))
            {
                answerS += j;
                str = "";
            }
        }
        
        answer = Int32.Parse(answerS);
                
        return answer;
    }
}