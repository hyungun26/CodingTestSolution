using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        List<int> list = new List<int>();
        int num = n;
        int a = 2;
        int stop = 0;
        while(num != 1)
        {
            if(num % a == 0)
            {
                list.Add(a);
                num /= a;
                a = 2;
            }
            else
            {
                a++;
            }
        }
        list.Sort();
        list = list.Distinct().ToList();
        
        return list.ToArray();
    }
}