using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        int[] answer = new int[] {};
        List<int> list = new List<int>();
        for(int i = 0; i < flag.Length; i++)
        {
            int num = 0;
            if(flag[i])
            {
                num = 2 * arr[i];
            }
            else
                num = arr[i];
            
            for(int j = 0; j < num; j++)
            {
                if(flag[i])
                    list.Add(arr[i]);
                else
                {
                    list.RemoveAt(list.Count-1);
                }
            }
        }
        return list.ToArray();
    }
}