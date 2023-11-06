using System;
using System.Text;
public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        sb.Append(phone_number);
        int num = phone_number.Length-4;
        sb.Remove(0, num);
        for(int i = 0; i < num; i++){answer += "*";}
        sb.Insert(0, answer);
        return sb.ToString();
    }
}