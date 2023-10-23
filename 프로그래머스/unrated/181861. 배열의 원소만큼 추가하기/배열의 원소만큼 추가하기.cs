using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        Queue<int> q = new Queue<int>();
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr[i]; j++)
            {
                q.Enqueue(arr[i]);
            }
        }
        int[] answer = new int[q.Count];
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = q.Dequeue();
        }

        return answer;
    }
}