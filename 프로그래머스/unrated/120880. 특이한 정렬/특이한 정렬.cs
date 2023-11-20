using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numlist, int n) {
        int[] answer = new int[numlist.Length];
        int[] iArr = new int[numlist.Length];
        List<int> list = new List<int>();
        for(int i = 0; i < answer.Length; i++)
        {
            iArr[i] = numlist[i] - n;
        }
        int num = Math.Abs(iArr.Min()) > Math.Abs(iArr.Max()) ? Math.Abs(iArr.Min()) : Math.Abs(iArr.Max());
        for(int i = 0; i <= num; i++)
        {   
            for(int j = 0; j < iArr.Length; j++)
            {
                if(i == Math.Abs(iArr[j]))
                {
                    list.Add(iArr[j]);
                }
            }
        }
        num = list.Count;
        for(int i = 0; i < num -1; i++)
        {
            if(Math.Abs(list[i]) == Math.Abs(list[i+1]))
            {
                if(list[i] < list[i+1]) // 중복값인데 앞이 -이면 순서바꾸기
                {
                    int some = list[i];
                    list[i] = list[i+1];
                    list[i+1] = some;
                }
            }
        }
        for(int i = 0; i < list.Count; i++)
        {
            list[i] += n;
        }
        return list.ToArray();
    }
}