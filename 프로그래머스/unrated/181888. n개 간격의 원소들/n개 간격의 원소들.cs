using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        Queue<int> q = new Queue<int>();
        for(int i = 0; i < num_list.Length; i++)
        {
            if(i % n == 0)
                q.Enqueue(num_list[i]);
        }
        
        int[] answer = new int[q.Count];
        
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = q.Dequeue();    
        }
        
        return answer;
    }
}