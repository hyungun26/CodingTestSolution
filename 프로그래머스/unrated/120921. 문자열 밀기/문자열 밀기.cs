using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string A, string B) {
        int answer = -1;
        int num = 1;
        List<char> list = new List<char>();
        for(int i = 0; i < A.Length; i++)
        {
            list.Add(A[i]);
        }
        if(A == B)
            return 0;
        for(int i = 0; i < A.Length; i++)
        {
            list.Insert(0, list[list.Count-1]);
            list.RemoveAt(list.Count-1);
            string s = "";
            for(int j = 0; j < list.Count; j++)
            {
                s += list[j];
            }
            if(s == B)
            {
                return num;
            }
            num++;
        }
        return answer;
    }
}