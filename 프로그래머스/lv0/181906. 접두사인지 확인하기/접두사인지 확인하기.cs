using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 0;
        string s = "";
        if(my_string.Length > is_prefix.Length)
        {
            s = my_string.Substring(0, is_prefix.Length);    
        }
        Console.Write(s);
        
        if(s == is_prefix)
            return 1;
        return answer;
    }
}