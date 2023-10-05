using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] bab = new string[] {"aya", "ye", "woo", "ma"};
        
        for(int i = 0; i < babbling.Length; i++)
        {
            for(int j = 0; j < bab.Length; j++)
            {
                if(babbling[i].Contains(bab[j]))
                {
                    babbling[i] = babbling[i].Replace(bab[j], $"{j+1}");
                }
            }
        }

        for(int i = 0; i < babbling.Length; i++)
        {
            if(Int32.TryParse(babbling[i], out int j))
            {
                string s = j.ToString();
                
                if(s.Length == 1)
                    answer++;
                else
                {
                    for(int q = 0; q < s.Length-1; q++)
                    {
                        if(s[q] == s[q+1])
                            break;
                        if(q == s.Length-2)
                            answer++;
                    }
                }
            }
        }
        return answer;
    }
}