using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string solution(string a, string b) {
        string answer = "";
        bool check = false;
        StringBuilder sb = new StringBuilder();
        if (a.Length > b.Length)
        {
            sb.Append(b);
            check = false;
        }
        else
        {
            sb.Append(a);
            check = true;
        }
        int num = Math.Abs(a.Length - b.Length);
        for(int i = 0; i < num; i++)
        {
            sb.Insert(0, 0);
        }
        if (check)
            a = sb.ToString();
        else
            b = sb.ToString();

        List<int> list = new List<int>();
        int some = 0;
        for (int i = a.Length; i > 0; i--)
        {
            int an = a[i - 1] % 48;
            int bn = b[i - 1] % 48;
            int sum = an + bn + some;
            list.Add(sum % 10);
            if (sum >= 10)
            {
                some = 1;
            }
            else
                some = 0;
            if (some == 1 && i == 1)
                list.Add(1);
        }
        list.Reverse();
        foreach(var i in list)
        {
            answer += i;
        }
        
        return answer;
    }
}