using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int count = 0;
        char[] cArr = s.ToCharArray();
        char c = cArr[0];
        for(int i = 0; i < s.Length-1; i++)
        {
            if(c == cArr[i]) //첫번째 단어와 같은지 갯수 비교
            {
                count++;
            }
            else if(c != cArr[i])
            {
                count--;
            }
            
            if(count == 0)
            {                
                c = cArr[i+1];
                answer++;
            }
        }
        
        answer += 1;
        
        return answer;
    }
}