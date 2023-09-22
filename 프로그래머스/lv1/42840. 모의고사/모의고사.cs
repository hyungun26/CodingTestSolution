using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        int[] su1 = {1, 2, 3, 4, 5};
        int su1C = 0;
        int[] su2 = {2, 1, 2, 3, 2, 4, 2, 5};
        int su2C = 0;
        int[] su3 = {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        int su3C = 0;
        
        int count = 1;
        int size = su1.Length;
        
        while(size < answers.Length)
        {
            count++;
            size += su1.Length;
        }
        
        Array.Resize(ref su1, su1.Length * count);
        Array.Resize(ref su2, su2.Length * count);
        Array.Resize(ref su3, su3.Length * count);
        
        for(int i = 0; i < answers.Length; i++)
        {
            su1[i] = su1[i % (su1.Length / count)];
        }
        for(int i = 0; i < answers.Length; i++)
        {
            su2[i] = su2[i % (su2.Length / count)];
        }
        for(int i = 0; i < answers.Length; i++)
        {
            su3[i] = su3[i % (su3.Length / count)];
        }
        
        for(int i = 0; i < answers.Length; i++)
        {
           if(answers[i] == su1[i])
           {
                su1C++;
           }
            if(answers[i] == su2[i])
           {
                su2C++;
           }
            if(answers[i] == su3[i])
           {
                su3C++;
           }
        }
        
        int a = 0;

        //최고점수를 구함
        int[] iArr = new int[3];
        iArr[0] = su1C;
        iArr[1] = su2C;
        iArr[2] = su3C;
        
        a = iArr.Max();
        int c = 0;
        
        for(int i = 0; i < iArr.Length; i++)
        {
            if(a == iArr[i])
            {
                c++;
            }
        }
        
        int[] answer = new int[c];
        int cs = 0;
        for(int i = 0; i < iArr.Length; i++)
        {
            if(a == iArr[i])
            {
                answer[cs] = i+1;
                cs++;
            }
        }
        
        return answer;
    }
}