using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> list = new List<int>();
        foreach(var i in arr)
        {
            list.AddRange(Enumerable.Repeat(i, i));
        }
        return list.ToArray();
    }
}