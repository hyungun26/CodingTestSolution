using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string, int[] indices) {
        string answer = "";
        char[] cArr = my_string.ToCharArray();
        List<char> list = new List<char>();
        foreach(var i in cArr)
        {
            list.Add(i);
        }
        Array.Sort(indices);
        Array.Reverse(indices);
        for(int i = 0; i < indices.Length; i++)
        {
            list.RemoveAt(indices[i]);
        }
        foreach(var i in list)
        {
            answer += i;
        }
        return answer;
    }
}