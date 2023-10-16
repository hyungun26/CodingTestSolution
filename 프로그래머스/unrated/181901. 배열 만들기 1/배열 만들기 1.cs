using System;
using System.Linq;

public class Solution {
    public int[] solution(int n, int k) {
        int[] answer = new int[n / k];
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = k * (i+1);
        }
        return answer;
    }
}