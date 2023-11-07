using System;
using System.Linq;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string s = "";
        for(int i = 0; i < my_string.Length; i++)
        {
            if(Int32.TryParse(my_string[i].ToString(), out int j))
            {
                s += j;
            }
            else
                s += " ";
        }
        string[] sArr = s.Split();
        for(int i = 0; i < sArr.Length; i++)
        {
            if(sArr[i] != "")
                answer += int.Parse(sArr[i]);
        }
        return answer;
    }
}