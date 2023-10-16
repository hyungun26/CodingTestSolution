using System;
using System.Linq;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        char[] cArr = s.ToCharArray();
        string a = new string("abcdefghijklmnopqrstuvwxyz".Where(x => !skip.Contains(x)).ToArray());
        char[] aArr = a.ToCharArray();
        Array.Sort(aArr);

        for(int i = 0; i < cArr.Length; i++)
        {
            int num = Array.IndexOf(aArr, cArr[i]);
            int sum = num+index;
            if(sum >= aArr.Length)
            {
                sum = sum % aArr.Length;
            }    
            answer += aArr[sum];
        }
        
        return answer;
    }
}