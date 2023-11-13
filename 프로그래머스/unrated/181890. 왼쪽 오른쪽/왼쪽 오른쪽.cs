using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] str_list) {
        string s = "";
        string check = "";
        
        for(int i = 0; i < str_list.Length; i++)
        {
            check += str_list[i];
            if(str_list[i] == "l")
            {
                break;
            }
            else if(str_list[i] == "r")
            {
                s = "";
                for(int j = i+1; j < str_list.Length; j++)
                {
                    s += str_list[j];
                }
                break;
            }
            s += str_list[i];
        }        
        string[] answer = new string[s.Length];
        if(check.Contains("l") || check.Contains("r")){}
        else
        {
            string[] a = new string[0];
            return a;
        }
        
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = s[i].ToString();
        }
        
        return answer;
    }
}