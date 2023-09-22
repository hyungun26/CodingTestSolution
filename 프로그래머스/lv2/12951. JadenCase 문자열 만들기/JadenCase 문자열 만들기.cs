using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string s) {
        string answer = "";
        List<char> a = new List<char>();
        char[] b = s.ToCharArray();
        
        for(int i = 0; i < b.Length; i++)
        {
            a.Add(b[i]);
        }
        
        a.Insert(0, ' ');
        
        for(int i = 0; i < a.Count; i++)// 전부 소문자로 변환
        {
            a[i] = Char.ToLower(a[i]);
        }
        
        for(int i = 0; i < a.Count; i++)
        {
            
            if(i == a.Count-1 && a[i] == ' ')
            {
                break;
            }
                
            if(a[i] == ' ' && Char.IsLower(a[i+1]))
            {   
                a[i+1] = Char.ToUpper(a[i+1]);
            }
        }
        
        a.RemoveAt(0);
        
        foreach(var i in a)
        {
            answer += i;
        }
        
        return answer;
    }
}