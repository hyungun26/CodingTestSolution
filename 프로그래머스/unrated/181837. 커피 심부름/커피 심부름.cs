using System;

public class Solution {
    public int solution(string[] order) {
        int answer = 0;
        for(int i = 0; i < order.GetLength(0); i++)
        {
            if(order[i].Contains("latte"))
                answer += 5000;
            else
                answer += 4500;
        }
        return answer;
    }
}