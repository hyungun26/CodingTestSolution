using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string, int[,] queries) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        sb.Append(my_string);
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            List<char> list = new List<char>();
            string s = sb.ToString().Substring(queries[i, 0], queries[i, 1] - queries[i, 0] + 1);
            sb.Remove(queries[i, 0], queries[i, 1] - queries[i, 0] + 1);
            string newStr = "";
            for(int j = 0; j < s.Length; j++)
            {
                list.Add(s[j]);
            }
            list.Reverse();
            for(int j = 0; j < list.Count; j++)
            {
                newStr += list[j];
            }
            sb.Insert(queries[i, 0], newStr);
        }
        return sb.ToString();
    }
}