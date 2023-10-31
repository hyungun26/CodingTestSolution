using System;

public class Solution {
    public int solution(string number) {
        int answer = 0;
        for(int i = 0; i < number.Length; i++)
        {
            answer += (int)(number[i]) % 48;
        }
        answer %= 9;
        
        return answer;
    }
}