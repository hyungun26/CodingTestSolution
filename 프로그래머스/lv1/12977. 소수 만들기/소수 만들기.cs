using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0; 
        int count = 0;
        List<int> list = new List<int>();
        for(int i = 0; i < nums.Length; i++) 
        {
            for(int j = i+1; j < nums.Length; j++) 
            {
                for(int k = j+1; k < nums.Length; k++) 
                {
                    list.Add(nums[i] + nums[j] + nums[k]);                    
                }
            }
        }
        
        for(int i = 0; i < list.Count; i++)
        {
            for(int j = 1; j <= list[i]; j++)
            {
                if(list[i] % j == 0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                answer++;
            }
            count = 0;
        }
            
        
        return answer;
    }
}