using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int sum = 0;
        int mul = 1;
        for(int i = 0; i < num_list.Length; i++)
        {
            sum += num_list[i];
            mul *= num_list[i];
        }
        sum *= sum;
        answer = sum > mul ? 1 : 0;
        return answer;
    }
}