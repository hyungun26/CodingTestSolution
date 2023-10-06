using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        int[] iArr = new int[n+2];
        int lostNum = 0;
        int reserveNum = 0;
        for(int i = 0; i < n+2; i++)
        {
            iArr[i] = 1;
        }
        iArr[0] = 3;
        iArr[iArr.Length-1] = 3;
        for(int i = 0; i < lost.Length; i++)
        {
            iArr[lost[i]] -= 1;
        }
        for(int i = 0; i < reserve.Length; i++)
        {
            iArr[reserve[i]] += 1;
        }
        
        for(int i = 0; i < iArr.Length; i++)
        {
            if(iArr[i] == 2)
            {
                if(iArr[i-1] == 0)
                {
                    iArr[i] -= 1;
                    iArr[i-1] += 1;
                    continue;
                }
                if(iArr[i+1] == 0)
                {
                    iArr[i] -= 1;
                    iArr[i+1] += 1;
                }
            }
        }
        
        for(int i = 0; i < iArr.Length; i++)
        {
            if(iArr[i] == 1 || iArr[i] == 2)
                answer++;
        }
      
        foreach(var i in iArr)
        {
            Console.Write(i);
        }
        
        return answer;
    }
}