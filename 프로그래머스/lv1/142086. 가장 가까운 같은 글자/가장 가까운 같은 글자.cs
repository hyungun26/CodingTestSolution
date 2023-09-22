using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        List<char> list = new List<char>();
        char[] cArr = s.ToCharArray();
        
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = -1;
            list.Add(cArr[i]);
        }
        
        for(int i = 0; i < cArr.Length; i++)
        {
            for(int j = i+1; j < list.Count; j++)
            {
                if(list[i] == list[j])
                {
                    answer[j] = j - i;
                    break;
                }
            }
        }
        
        
        return answer;
    }
}