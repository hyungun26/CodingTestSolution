using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        List<int> list = new List<int>();
        char[] cArr = keymap[0].ToCharArray();
        for(int i = 0; i < keymap.Length; i++)
        {
            for(int j = 0; j < keymap[i].Length; j++)
            {
                if(dic.ContainsKey(keymap[i][j]))
                {   
                    if(dic[keymap[i][j]] > j)
                    {
                        dic.Remove(keymap[i][j]);
                        dic.Add(keymap[i][j], j+1);    
                    }
                }
                else
                {
                    dic.Add(keymap[i][j], j+1);
                }
            }
        }
        int num = 0;
        for(int i = 0; i < targets.Length; i++)
        {
            for(int j = 0; j < targets[i].Length; j++)
            {
                if(dic.ContainsKey(targets[i][j]))
                {
                    num += dic[targets[i][j]];
                }
                else //keymap에 targets가 없으면 targets 원소 구역을 -1로 return해야한다.
                {
                    num = Int32.MinValue;
                }
            }
            list.Add(num);
            num = 0;
        }
        
        int[] answer = new int[list.Count];
        
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = list[i];
            if(answer[i] < 0)
            {
                answer[i] = -1;
            }
        }
        
        
        return answer;
    }
}