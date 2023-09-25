using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[arr.Length];
        
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            int a = arr[queries[i,0]];
            Console.Write(a);
            int b = arr[queries[i,1]];
            arr[queries[i,0]] = b;
            arr[queries[i,1]] = a;
        }
        
        for(int i = 0; i < arr.Length; i++)
        {
            answer[i] = arr[i];
        }
        
        return answer;
    }
}