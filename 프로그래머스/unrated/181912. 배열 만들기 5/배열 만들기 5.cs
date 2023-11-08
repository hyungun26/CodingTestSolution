using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        int[] answer = new int[] {};
        List<int> list = new List<int>();
        for(int i = 0; i < intStrs.Length; i++)
        {
            int num = int.Parse(intStrs[i].Substring(s,l));
            if(num > k)
                list.Add(num);
        }
        return list.ToArray();
    }
}