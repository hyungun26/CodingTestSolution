using System;
using System.Text;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        string answer = "";
        StringBuilder str = new StringBuilder();
        str.Append(my_string.Substring(0, s));
        str.Append(overwrite_string);
        Console.Write(str.Length);
        Console.Write(my_string.Length);
        if(str.Length != my_string.Length)
        {
            str.Append(my_string.Substring(str.Length, my_string.Length - str.Length));
        }
        //Console.Write(my_string.Substring(str.Length, my_string.Length));
        
        answer = str.ToString();
        return answer;
    }
}