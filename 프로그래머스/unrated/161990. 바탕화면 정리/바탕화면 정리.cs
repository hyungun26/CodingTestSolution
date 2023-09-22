using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];
        int num = 0;
        
        answer[0] = int.MaxValue;
        answer[1] = int.MaxValue;
        //대충 맨왼쪽 맨위 맨오른쪽 맨아래 값을 구할줄만 알면 풀 수 있다.
        for(int i = 0; i < wallpaper.Length; i++)
        {
            string s = wallpaper[i];
            char[] cArr = s.ToCharArray();
            
            for(int j = 0; j < cArr.Length; j++)
            {
                if(cArr[j] == '#')
                {
                    
                    if(answer[0] > i)
                    {
                        answer[0] = i;    
                    }
                    if(answer[1] > j)
                    {
                        answer[1] = j;    
                    }
                    
                    if(answer[2] <= i)
                    {
                        answer[2] = i + 1;    
                    }
                    if(answer[3] <= j)
                    {
                        answer[3] = j + 1;    
                    }
                }
            }
        }
        
        
        return answer;
    }
}