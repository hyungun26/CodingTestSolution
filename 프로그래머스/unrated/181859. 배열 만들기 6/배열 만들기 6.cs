using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        List<int> stk = new List<int>();
        
        for(int i = 0; i < arr.Length;)
        {
            if(stk.Count == 0)
            {
                stk.Add(arr[i]);
                i++;
            }
            if(arr.Length == i)
                return stk.ToArray();
            if(stk[stk.Count-1] == arr[i])
            {
                stk.RemoveAt(stk.Count-1);
                i++;
            }
            else if(stk[stk.Count-1] != arr[i])
            {
                stk.Add(arr[i]);
                i++;
            }
        }
        if(stk.Count == 0)
            stk.Add(-1);
            
        return stk.ToArray();
    }
}