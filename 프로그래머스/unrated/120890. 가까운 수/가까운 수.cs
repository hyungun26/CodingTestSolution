using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int check = 100;
        Array.Sort(array);
        for(int i = 0; i < array.Length; i++)
        {
            int num = Math.Abs(array[i] - n);
            if(check > num)
            {
                check = num;
                answer = array[i];
            }
        }
        return answer;
    }
}