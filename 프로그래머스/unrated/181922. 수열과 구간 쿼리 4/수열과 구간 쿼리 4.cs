using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[] {};
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            for(int j = 0; j < arr.Length; j++)
            {
                if(queries[i,0] <= j && j <= queries[i,1] && j % queries[i,2] == 0)
                    arr[j]++;
            }
        }
        return arr;
    }
}