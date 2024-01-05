using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        string[] answer = new string[players.Length];
        Dictionary<string,int> nameDic = new Dictionary<string,int>();
        Dictionary<int,string> numberDic = new Dictionary<int,string>();

        for(int i=0; i<players.Length; i++)
        {
            nameDic.Add(players[i],i);
            numberDic.Add(i,players[i]);
        }
        for(int i = 0; i < callings.Length; i++)
        {
            int n = nameDic[callings[i]];
            string s = numberDic[nameDic[callings[i]]];
            string ss = numberDic[nameDic[callings[i]] -1];
            numberDic.Remove(n);
            numberDic.Remove(n-1);
            numberDic.Add(n, ss);
            numberDic.Add(n-1, s);
            nameDic.Remove(s);
            nameDic.Remove(ss);
            nameDic.Add(s, n-1);
            nameDic.Add(ss, n);
        }
        numberDic = numberDic.OrderBy(item => item.Key).ToDictionary(x => x.Key, x => x.Value);
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = numberDic[i];
        }
        return answer;
    }
}