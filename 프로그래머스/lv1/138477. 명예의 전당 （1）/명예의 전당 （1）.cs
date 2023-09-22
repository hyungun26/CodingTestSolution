using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> list = new List<int>();
        
        for(int i = 0; i < score.Length; i++)
        {
            list.Add(score[i]);
            if(list.Count == k+1)
            {
                list.Sort();
                list.Remove(list.Min());
            }
            answer[i] = list.Min();
        }
        
        return answer;
    }
}