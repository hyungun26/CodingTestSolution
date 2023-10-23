using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        string[] sArr = my_string.Split();
        List<string> list = new List<string>();
        for (int i = 0; i < sArr.GetLength(0); i++)
        {
            if(sArr[i] != "")
            {
                list.Add(sArr[i]);
            }
        }
        string[] answer = new string[list.Count];
        for(int i = 0; i < list.Count; i++)
        {
            answer[i] = list[i];
        }
        return answer;
    }
}