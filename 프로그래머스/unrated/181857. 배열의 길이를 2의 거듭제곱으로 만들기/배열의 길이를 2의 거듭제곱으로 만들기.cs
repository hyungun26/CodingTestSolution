using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        if(arr.Length == 1)
            return arr;
        int num = arr.Length;
        int a = 2;
        List<int> list = new List<int>();
        list = arr.ToList();
        while(num > a)
        {
            a *= 2;
        }
        for(int i = 0; i < a - num; i++)
        {
            list.Add(0);
        }
        return list.ToArray();
    }
}