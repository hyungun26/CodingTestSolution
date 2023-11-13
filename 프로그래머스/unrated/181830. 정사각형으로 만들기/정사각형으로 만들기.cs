using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        int a = arr.GetLength(0);
        int b = arr.GetLength(1);
        int num = a > b ? a : b;
        int[,] answer = new int[num, num];
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                answer[i,j] = arr[i,j];
            }
        }
        return answer;
    }
}