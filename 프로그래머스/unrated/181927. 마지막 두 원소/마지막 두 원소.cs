using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length+1];
        int num = 0;
        if(num_list[num_list.Length-1] > num_list[num_list.Length-2])
            num = num_list[num_list.Length -1] - num_list[num_list.Length-2];
        else
            num = num_list[num_list.Length-1] * 2;
        
        for(int i = 0; i < answer.Length-1; i++)
        {
            answer[i] = num_list[i];
        }
        answer[num_list.Length] = num;
        return answer;
    }
}