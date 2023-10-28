using System;

public class Solution {
    public int solution(int[] arr, int idx) {
        int num = idx;
        for(int i = num; i < arr.Length; i++)
        {
            if(arr[i] == 1)
            {
                idx = i;
                break;
            }
            idx = -1;
        }
        return idx;
    }
}