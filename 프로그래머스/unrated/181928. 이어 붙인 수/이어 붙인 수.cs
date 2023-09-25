using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        string sOdd = "";
        string sEven = "";
        for(int i = 0; i < num_list.Length; i++)
        {

            if(num_list[i] % 2 == 0)
            {
                sEven += num_list[i].ToString();
            }
            else 
            {
                sOdd += num_list[i].ToString(); 
            }
        }
        answer = Int32.Parse(sEven) + Int32.Parse(sOdd);
        
        return answer;
    }
}