using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[] query) {
        int[] answer = new int[] {};
        List<int> list = new List<int>();
        list = arr.ToList();
        for(int i = 0; i < query.Length; i++)
        {
            if(i % 2 == 0)
            {
                list.RemoveRange(query[i]+1, list.Count-query[i]-1);
            } 
            else
            {
                list.RemoveRange(0, query[i]);
            }       
        }
        return list.ToArray();
    }
}