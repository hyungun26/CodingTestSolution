using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        int val = 0;
        for(int i = 0; i < number.Length; i++)
        {
            for(int j = i+1; j < number.Length; j++)
            {
                for(int k = j+1; k < number.Length; k++)
                {
                    val = number[i] + number[j] + number[k];
                    if(val == 0)
                        answer++;
                }
            }
        }
        return answer;
    }
}