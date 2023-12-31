using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
        int[] rank = Enumerable.Repeat(1, emergency.Length).ToArray();
        for(int i = 0; i < emergency.Length; i++)
        {
            for(int j = 0; j < emergency.Length; j++)
            {
                if(emergency[i] < emergency[j])
                {
                    rank[i]++;
                }
            }
        }
        
        return rank;
    }
}