using System;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = my_string.Substring(s, e - s+1);
        char[] cArr = answer.ToCharArray();
        StringBuilder sb = new StringBuilder();
        sb.Append(my_string);
        sb.Remove(s, e-s+1);
        Array.Reverse(cArr);
        answer = "";
        for(int i = 0; i < cArr.Length; i++)
        {
            answer += cArr[i];
        }
        sb.Insert(s, answer);
        return sb.ToString();
    }
}