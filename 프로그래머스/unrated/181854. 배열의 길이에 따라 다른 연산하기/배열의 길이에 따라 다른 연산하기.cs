using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int check = arr.Length % 2 == 0 ? 0 : 1;
        for(int i = 0; i < arr.Length; i++)
        {
            if(i % 2 != check)
            {
                arr[i] = arr[i] + n;
            }
        }
        return arr;
    }
}