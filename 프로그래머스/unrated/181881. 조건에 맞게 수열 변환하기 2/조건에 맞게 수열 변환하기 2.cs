using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        int[] iArr = arr.ToArray();
        do{
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 50 && arr[i] % 2 == 1) // 50보다 작고 홀수 이면
                {
                    arr[i] = arr[i] * 2 + 1;
                }
                else if(arr[i] >= 50 && arr[i] % 2 == 0) // 50보다 크거나 같고 짝수 이면
                {
                    arr[i] = arr[i] / 2;
                }
            }      
            if(Enumerable.SequenceEqual(arr, iArr))
                return answer;
            else
                iArr = arr.ToArray();
            answer++;
        }while(Enumerable.SequenceEqual(arr, iArr));
        
        return answer;
    }
}