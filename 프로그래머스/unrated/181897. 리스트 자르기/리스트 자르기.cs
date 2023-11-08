using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        List<int> list = new List<int>();
        switch(n)
        {
            case 1: list = num_list.Take(slicer[1]+1).ToList();
                break;
            case 2: list = num_list.Skip(slicer[0]).ToList();
                break;
            case 3: list = num_list.Skip(slicer[0]).Take(slicer[1] - slicer[0] + 1).ToList();
                break;
            case 4: 
                for(int i = slicer[0]; i <= slicer[1]; i+=slicer[2])
                {
                    list.Add(num_list[i]);
                }
                break;
        }
        return list.ToArray();
    }
}