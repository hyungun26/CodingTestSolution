using System;
using System.Linq;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int answer = 0;
        int[] iArr = new int[rank.Length];
        int[] RankIndex = new int[3];
        for(int i = 0 ; i < iArr.Length; i++)
        {
            if(attendance[i])
                iArr[i] = rank[i];
        }
        int num = 0;
        for(int i = 1; i <= iArr.Max(); i++)
        {
            if(num > 2)
                break;
            for(int j = 0; j < iArr.Length; j++)
            {
                if(i == iArr[j])
                {
                    RankIndex[num] = j;
                    num++;
                    if(num > 2)
                        break;
                    continue;
                }
            }
        }
        answer = 10000 * RankIndex[0] + 100 * RankIndex[1] + RankIndex[2];
        return answer;
    }
}