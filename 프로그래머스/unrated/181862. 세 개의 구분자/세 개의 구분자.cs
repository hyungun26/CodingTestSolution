using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string myStr) {
        string s = myStr.Replace("a", " ").Replace("b", " ").Replace("c", " ");
        string[] answer = s.Split();
        List<string> list = new List<string>();
        foreach(var i in answer)
        {
            if(i != "")
                list.Add(i);
        }
        if(list.Count == 0)
        {
           list.Add("EMPTY");
        }
            
        return list.ToArray();
    }
}