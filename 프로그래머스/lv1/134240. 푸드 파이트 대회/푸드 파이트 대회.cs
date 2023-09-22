using System;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        int num = 0;
        Stack<int> stack = new Stack<int>();
        
        for(int i = 0; i < food.Length-1; i++)
        {
            num = food[i+1] / 2;
            for(int j = 0; j < num; j++)
            {
                stack.Push(i+1);
                answer += i+1;
            }
        }
        
        answer += "0";
        foreach(var i in stack)
        {
            answer += i;
        }
        return answer;
    }
}