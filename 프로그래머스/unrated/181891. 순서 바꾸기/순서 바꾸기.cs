using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length];
        Queue<int> q = new Queue<int>();
        foreach(var i in num_list)
        {
            q.Enqueue(i);
        }
        for(int i = 0 ; i < n; i++)
        {
            q.Enqueue(q.Peek());
            q.Dequeue();
        }
        for(int i = 0; i < num_list.Length; i++)
        {
            answer[i] = q.Dequeue();
        }
        return answer;
    }
}