using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string myString) {
        string[] answer = myString.Replace("x", " ").Split();
        List<string> list = new List<string>();
        Array.Sort(answer);
        for(int i = 0; i < answer.GetLength(0); i++)
        {
            if(answer[i] != "")
            {
                list.Add(answer[i]);
            }
        }
        return list.ToArray();
    }
}