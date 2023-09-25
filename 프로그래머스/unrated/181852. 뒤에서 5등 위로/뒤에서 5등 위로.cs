using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length - 5];
        List<int> list = new List<int>();
        foreach(var i in num_list)
        {
            list.Add(i);
        }
        list.Sort();
        
        for(int i = 0; i < 5; i++)
        {
            list.RemoveAt(0);    
        }
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = list[i];
        }
        
        return answer;
    }
}