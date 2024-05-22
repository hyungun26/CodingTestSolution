using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> answer = new List<int>();
        int[] a1 = {1,2,3,4,5};
        int[] a2 = {2,1,2,3,2,4,2,5};
        int[] a3 = {3,3,1,1,2,2,4,4,5,5};
        int a1Num = 0;
        int a1A = 0;
        
        int a2Num = 0;
        int a2A = 0;
        
        int a3Num = 0;
        int a3A = 0;
        //여기서 문제 찍는 배열이 answer배열 길이보다 길어야함
        for(int i = 0; i < answers.Length; i++)
        {
            a1A = ss(a1, a1Num, a1A, i, answers);
            if((i+1) % a1.Length == 0)
            {
                a1Num += a1.Length;
            }
            a2A = ss(a2, a2Num, a2A, i, answers);
            if((i+1) % a2.Length == 0)
            {
                a2Num += a2.Length;
            }
            a3A = ss(a3, a3Num, a3A, i, answers);
            if((i+1) % a3.Length == 0)
            {
                a3Num += a3.Length;
            }
        }     
        
        answer.Add(a1A);
        answer.Add(a2A);
        answer.Add(a3A);
        
        List<int> lstAnswer = new List<int>();
        
        if (answer[0] == answer.Max()) lstAnswer.Add(1);
        if (answer[1] == answer.Max()) lstAnswer.Add(2);
        if (answer[2] == answer.Max()) lstAnswer.Add(3);
        
        return lstAnswer.ToArray();
    }
    public int ss(int[] a, int b, int c,int i, int[] answers)
    {
        if(a[i-b] == answers[i])
        {
            c++;
        }
        return c;
    }
}