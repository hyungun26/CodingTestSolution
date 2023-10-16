using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        int[] answer = new int[] {};
        for(int i = 0; i < delete_list.Length; i++)
        {
            if(arr.Contains(delete_list[i]))
            {
                arr = arr.Where(x=>x != delete_list[i]).ToArray();        
            }
        }
        
        return arr;
    }
}