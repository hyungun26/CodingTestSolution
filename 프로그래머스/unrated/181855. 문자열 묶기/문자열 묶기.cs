using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(string[] strArr) {
        List<int> list = new List<int>();
        for(int i = 0; i < strArr.Length; i++)
        {
            list.Add(strArr[i].Length);
        }
        int[] iArr = new int[list.Distinct().Count()];
        int a = 0;
        for(int i = 1; i <= list.Max(); i++)
        {
            for(int j = 0; j < list.Count(); j++)
            {
                if(list[j] == i)
                    iArr[i-1]++;
            }
        }
        return iArr.Max();
    }
}