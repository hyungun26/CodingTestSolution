using System;
using System.Linq;

public class Solution {
    public int[] solution(int[,] score) {
        double[] answer = new double[score.GetLength(0)];
        int[] myArray = Enumerable.Repeat(1, answer.Length).ToArray();
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = ((double)score[i,0] + (double)score[i,1]) / 2;
        }
        for(int i = 0; i < myArray.Length; i++)
        {
            for(int j = 0; j < answer.Length; j++)
            {
                if(answer[i] > answer[j])   
                {
                    myArray[j]++;
                }
            }
        }
        return myArray;
    }
}