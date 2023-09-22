using System;
using System.Text;

public class Solution {
    public string solution(string rny_string) {
        string answer = "";
        StringBuilder str = new StringBuilder();
        str.Append(rny_string);
        str.Replace("m", "rn");
        answer = str.ToString();
        return answer;
    }
}