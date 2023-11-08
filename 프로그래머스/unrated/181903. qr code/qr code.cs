using System;
using System.Collections.Generic;
public class Solution {
    public string solution(int q, int r, string code) {
        string answer = "";
        List<int> list = new List<int>();
        for(int i = 0; i < code.Length; i++)
        {
            list.Add(i % q);
        }
        for(int i = 0; i < code.Length; i++)
        {
            if(list[i] == r)
                answer += code[i];
        }
        return answer;
    }
}