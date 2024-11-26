using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int[] answer = new int[] {};
        int[] c = new int[progresses.Length];
        List<int> list = new List<int>();
        for(int i = 0; i < progresses.Length; i++)
        {
            int count = 0;
            while(progresses[i] < 100)
            {
                progresses[i] += speeds[i];
                count++;
            }
            c[i] = count;
        }
        
        for(int i = 0; i < c.Length; i++)
        {
            int num = 1;
            for(int j = i + 1; j < c.Length; j++)
            {
                if(c[i] >= c[j])
                {
                    num++;
                    if(j + 1 == c.Length)
                        i = c.Length;
                }
                else
                {
                    i = j - 1;
                    break;
                }
            }
            list.Add(num);
        }
        
        return list.ToArray();
    }
}