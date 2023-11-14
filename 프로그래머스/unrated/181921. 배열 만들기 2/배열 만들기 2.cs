using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        int[] answer = new int[] {};
        int[] num = {1, 2, 3, 4, 6, 7, 8, 9};
        List<int> list = new List<int>();
        for(int i = l; i <= r; i++)
        {
            string s = i.ToString();
            if(s.Contains("1") || s.Contains("2") || s.Contains("3") || s.Contains("4") || s.Contains("6") || s.Contains("7") || s.Contains("8") || s.Contains("9"))
            {   
            }
            else
                list.Add(int.Parse(s));    
        }
        if(list.Count == 0)
            list.Add(-1);
        return list.ToArray();
    }
}