using System;
using System.Linq;

public class Solution {
    public int[] solution(string s) {
        int[] asdf = new int[5];
        char[] c = new char[s.Length];
        int t = 0;
        int r = 0;
        while(c.Length > 1)
        {
            int[] answer = new int[s.Length];
            c = s.ToCharArray();
            for(int i = 0; i < c.Length; i++)
            {
                answer[i] = (int)c[i] % 48; //0, 1뽑아서 answer int배열에 넣기
            }
            
            for(int i = 0; i < answer.Length; i++)
            {
                if(answer[i] == 0)
                {
                    r++;
                }
            }
            
            int[] newArray = answer.Where(num => num != 0).ToArray(); //0 제거
            
            int g = 0;
            foreach(var e in newArray)
            {
                g++;
            }
            
            s = Convert.ToString(g, 2);// 2진화     
            c = new char[s.Length];       
            t++;
        }
        asdf = new int[2];
        asdf[0] = t;
        asdf[1] = r;
        
        return asdf;
    }
}