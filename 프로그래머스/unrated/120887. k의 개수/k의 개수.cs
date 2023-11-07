using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        List<char> list = new List<char>();
        for(; i <= j; i++)
        {
            char[] cArr = i.ToString().ToCharArray();
            for(int t = 0; t < cArr.Length; t++)
            {
                list.Add(cArr[t]);
            }
        }
        foreach(var o in list)
        {
            if(o % 48 == k)
            {
                answer++;
            }
        }
        return answer;
    }
}