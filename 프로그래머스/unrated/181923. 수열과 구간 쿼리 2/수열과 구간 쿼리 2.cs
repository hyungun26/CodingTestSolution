using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        int num = 0;
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            int min = 1000000;
            bool check = false;
            for(int j = queries[i,0]; j <= queries[i,1]; j++)
            {
                if(queries[i,2] < arr[j])
                {
                    num = arr[j];
                    if(min > arr[j])
                        min = arr[j];
                    check = true;
                }
            }
            if(check) answer[i] = min;
            else
                answer[i] = -1;
        }
        return answer;
    }
}