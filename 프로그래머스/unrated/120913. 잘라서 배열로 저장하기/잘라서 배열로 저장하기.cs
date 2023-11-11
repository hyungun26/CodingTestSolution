using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string my_str, int n) {
        string[] answer = new string[] {};
        List<string> list = new List<string>();
        int num = 0;
        for(int i = 0; i < my_str.Length/n; i++)
        {
            list.Add(my_str.Substring(num, n));
            num += n;
        }
        if(list.Count*n != my_str.Length)
        {
            list.Add(my_str.Substring(num, my_str.Length-num));
        }
        return list.ToArray();
    }
}