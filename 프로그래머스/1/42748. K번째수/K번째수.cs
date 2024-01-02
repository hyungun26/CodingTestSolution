using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = array;
        List<int> list = new List<int>();
        for(int i = 0; i < commands.GetLength(0); i++)
        {
            int[] arr = answer.Skip(commands[i,0]-1).Take(commands[i,1]-commands[i,0]+1).ToArray();
            Array.Sort(arr);
            list.Add(arr[commands[i,2]-1]);
        }
        return list.ToArray();
    }
}