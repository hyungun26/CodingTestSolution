using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> list = new List<int>();
        int num = n;
        list.Add(num);
        while(num != 1)
        {
            if(num % 2 == 0)
                num /= 2;
            else
                num = num * 3 + 1;   
            list.Add(num);
        }
        return list.ToArray();
    }
}