using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> list = new List<int>();
        int a = Int32.MaxValue;
        
        for(int i = 0; i < arr.Length; i++)
        {
            list.Add(arr[i]);
            if(a > list[i]) //배열중 최고 작은수를 a에 담고
            {
                a = list[i];
            }
        }
        
        //문제를 보니 중복값에 대한 말이없음 최고작은 수의 갯수만큼 삭제시키면 해결될듯
        
        list.Remove(a); //최고 작은수 삭제
        
        int[] answer = new int[list.Count];
        if(list.Count == 0)
        {
            answer = new int[1];
            answer[0] = -1;
        }
        
        for(int i = 0; i < list.Count; i++)
        {
            answer[i] = list[i];
        }

        
        return answer;
    }
}