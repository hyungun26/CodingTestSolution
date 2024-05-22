using System;
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
            if(a1[i-a1Num] == answers[i])
            {
                a1A++;
            }
            if((i+1) % a1.Length == 0)
            {
                a1Num += a1.Length;
            }
            if(a2[i-a2Num] == answers[i])
            {
                a2A++;
            }
            if((i+1) % a2.Length == 0)
            {
                a2Num += a2.Length;
            }
            if(a3[i-a3Num] == answers[i])
            {
                a3A++;
            }
            if((i+1) % a3.Length == 0)
            {
                a3Num += a3.Length;
            }
        }     
        answer.Add(a1A);
        answer.Add(a2A);
        answer.Add(a3A);
        int num = a1A > a2A ? a1A : a2A;
        num = num > a3A ? num : a3A;
        
        List<int> an = new List<int>();
        for(int i = 0; i < answer.Count; i++)
        {
            if(answer[i] == num)
            {
                an.Add(i+1);
            }
        }
        
        return an.ToArray();
    }
}