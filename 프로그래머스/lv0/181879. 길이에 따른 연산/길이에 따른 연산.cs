using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int num = num_list.Length;
        answer = num > 10 ? 0 : 1;
        for(int i = 0; i < num; i++)
        {
            if(num > 10)
                answer += num_list[i];
            else
                answer *= num_list[i];
        }
        return answer;
    }
}