using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[strings.GetLength(0)];
        char[] cArr = new char[strings.GetLength(0)];
        List<string> list = new List<string>();
        
        Array.Sort(strings);
        
        for(int i = 0; i < strings.GetLength(0); i++)
        {
            list.Add(strings[i]);
            cArr[i] = strings[i][n];
        }
        
        Array.Sort(cArr);
        foreach(var i in list)
        {
            Console.WriteLine(i);
        }
        for(int i = 0; i < strings.GetLength(0); i++)
        {
            for(int j = 0; j < list.Count; j++)
            {
                if(cArr[i] == list[j][n])
                {
                    answer[i] = list[j];
                    list.RemoveAt(j);
                    break;
                }
            }
        }
        
        
        
        return answer;
    }
}