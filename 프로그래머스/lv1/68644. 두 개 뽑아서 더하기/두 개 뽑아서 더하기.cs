using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        int count = 0;
        
        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = i+1; j < numbers.Length; j++)
            {
                //answer[count] = numbers[i] + numbers[j];
                count++;
            }
        }
        
        int[] a = new int[count];
        count = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = i+1; j < numbers.Length; j++)
            {
                a[count] = numbers[i] + numbers[j];
                count++;
            }
        }
        answer = a.Distinct().ToArray();
        Array.Sort(answer);
        return answer;
    }
}