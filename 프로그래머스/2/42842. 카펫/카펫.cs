using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        List<int> list = new List<int>();
        for(int i = 1; i <= yellow; i++)
        {
            if(yellow % i == 0)
            {
                list.Add(i);
                Console.Write(i  + ", ");
            }
        }
        int num = list.Count / 2;
        int a = 0;
        if(list.Count % 2 == 0) //약수 짝수개
        {
            int b = 0;
            int c = 0;
            a = list[num] * 2 + list[num-1] * 2 + 4;
            while(a != brown)
            {
                b++;
                c--;
                a = list[num + b] * 2 + list[num-1 + c] * 2 + 4;
            }
            answer[0] = list[num + b] + 2;
            answer[1] = list[num-1 + c] + 2;
        }
        else if(list.Count % 2 != 0) //약수 홀수개
        {
            answer[0] = list[num] + 2;
            answer[1] = list[num] + 2;
        }
        else
        {
            answer[0] = 3;
            answer[1] = 3;
        }
        
        return answer;
    }
}