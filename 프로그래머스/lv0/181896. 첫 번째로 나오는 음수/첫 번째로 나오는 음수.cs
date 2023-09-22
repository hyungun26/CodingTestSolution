using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        for(int i = 0; i < num_list.Length; i++)
        {
            answer = num_list[i];
            if(answer < 0)
            {
                answer = i;
                break;
            }
            answer = -1;
        }
            
        return answer;
    }
}