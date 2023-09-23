using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] operations) {
        int[] answer = new int[2];
        Queue<string> q = new Queue<string>();
        List<int> list = new List<int>();
        foreach(var i in operations)
        {
            q.Enqueue(i);
        }
        
        for(int i = 0; i < operations.Length; i++)
        {
            if(Int32.TryParse(q.Peek().Replace("I", ""), out int j))
            {
                list.Add(j);
            }
            
            if(q.Peek() == "D 1" && list.Count != 0)
            {                
                list.Remove(list.Max());
            }
            else if(q.Peek() == "D -1" && list.Count != 0)
            {
                list.Remove(list.Min());
            }
            q.Dequeue();
        }
        if(list.Count != 0)
        {
            answer[0] = list.Max();
            answer[1] = list.Min();    
        }
        

        return answer;
    }
}