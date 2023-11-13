using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int k) {
        arr = arr.Distinct().ToArray();
        int[] answer = new int[k];
        int num = arr.Length > k ? k : arr.Length;
        for(int i = 0; i < num; i++)
        {
            answer[i] = arr[i];
        }
        for(int i = 1; i < answer.Length; i++)
        {
            if(answer[i] == 0)
                answer[i] = -1;
        }
        return answer;
    }
}