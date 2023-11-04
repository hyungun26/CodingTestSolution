using System;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        char[] cArr1 = X.ToCharArray();
        char[] cArr2 = Y.ToCharArray();
        Array.Sort(cArr1);
        Array.Sort(cArr2);
        
        int j = 0;
        for(int i = 0; i < cArr1.Length;)
        {
            if(cArr1[i] == cArr2[j])
            {
                sb.Append(cArr1[i]);
                i++;
                j++;
            }
            else
            {
                bool check = cArr1[i] > cArr2[j] ? true : false;
                if(check)
                    j++;
                else
                    i++;
            }
            if(j >= cArr2.Length)
                break;
        }
        Console.Write(sb.Length);
        char[] cArr = sb.ToString().ToCharArray();
        Array.Reverse(cArr);
        sb.Remove(0, sb.Length);
        foreach(var i in cArr)
        {
            sb.Append(i);
        }

        if(sb.ToString() == "")
            return "-1";
        if(sb[0] == '0')
            return "0";
        
        return sb.ToString();
    }
}