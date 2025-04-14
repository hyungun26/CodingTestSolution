using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers, int target) {
        int answer = 0;
        Queue<(int, int)> q = new Queue<(int, int)>();
        q.Enqueue((numbers[0], 1));
        q.Enqueue((-numbers[0], 1));
        while(q.Count > 0)
        {
            (int num, int idx) = q.Dequeue();
            if(idx == numbers.Length)
            {
                if(num == target)
                    answer++;
                continue;
            }
            q.Enqueue((num + numbers[idx], idx + 1));
            q.Enqueue((num - numbers[idx], idx + 1));
        }
        return answer;
    }
}