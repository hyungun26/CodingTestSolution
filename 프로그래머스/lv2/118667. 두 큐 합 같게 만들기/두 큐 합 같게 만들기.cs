using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] queue1, int[] queue2) {
        long answer = 0;
        long sum = 0;
        long listNum = 0;
        long listNum2 = 0;
        int a = 0;
        Queue<long> list = new Queue<long>();
        Queue<long> list2 = new Queue<long>();
        for(int i = 0; i < queue1.Length; i++)
        {
            listNum += queue1[i];
            listNum2 += queue2[i];
            list.Enqueue(queue1[i]);
            list2.Enqueue(queue2[i]);
        }
        
        if(answer % 2 != 0)
            return -1;

        while(listNum != listNum2)
        {     
            if(listNum == listNum2)
            {
                break;
            }
            else if(listNum < listNum2)
            {
                listNum += list2.Peek();
                listNum2 -= list2.Peek();
                list.Enqueue(list2.Peek());
                list2.Dequeue();
            }
            else
            {
                listNum -= list.Peek();
                listNum2 += list.Peek();
                list2.Enqueue(list.Peek());
                list.Dequeue();
            }
            
               if(a > 3000000)
                   return -1;
            a++;
        }
        return a;
    }
}