using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> list = new List<int>();
        List<int> list2 = new List<int>();
        for(int i = 2; i <= n; i++) list.Add(i);      
        
        for(int i = 2; i <= list.Count; i++)
        {
            int count = 0;
            for(int j = 2; j <= i; j++)
            {
                if(i % j == 0)
                {
                    count++;
                }
            }
            if(count == 1)
            {
                list2.Add(i);
                if(i*i > list.Count)
                    break;
            }
        }
        
        for(int i = 0; i < list2.Count; i++)
        {
            list = list.Where(c => c % list2[i] != 0).ToList();
        }

        return list.Count + list2.Count;
    }
}