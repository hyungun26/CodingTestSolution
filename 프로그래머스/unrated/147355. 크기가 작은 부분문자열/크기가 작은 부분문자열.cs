using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long b = Int64.Parse(p);
        string s = "";
        for(int i = 0; i < t.Length - p.Length + 1; i++)
        {
            s = t.Substring(i, p.Length);
            long a = Int64.Parse(s);
            if(b >= a)
            {
                answer++;
            }
        }
        
        return answer;
    }
}