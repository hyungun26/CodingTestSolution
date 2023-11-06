using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
        List<char> list = new List<char>();
        list = s.Distinct().ToList();
        list.Sort();
        int[] iArr = Enumerable.Repeat(0, list.Count).ToArray();
        for(int i = 0; i < s.Length; i++)
        {
            for(int j = 0; j < list.Count; j++)
            {
                if(s[i] == list[j])
                {
                    iArr[j] += 1;
                }
            }
        }
        for(int i = 0; i < list.Count; i++)
        {
            if(iArr[i] == 1)
            {
                answer += list[i];
            }
        }
        return answer;
    }
}