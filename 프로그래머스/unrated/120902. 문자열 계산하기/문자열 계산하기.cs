using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string[] sArr = my_string.Split();
        bool check = true;
        for(int i = 0; i < sArr.GetLength(0); i++)
        {
            if(Int32.TryParse(sArr[i], out int j))
            {
                if(check)
                    answer += j;    
                else
                    answer -= j;
                
            }
            else
            {
                if(sArr[i] == "+")
                    check = true;
                else 
                    check = false;
            }
        }
        return answer;
    }
}