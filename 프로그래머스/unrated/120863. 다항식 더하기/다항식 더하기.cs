using System;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        string[] sArr = polynomial.Split();
        int xNum = 0;
        int num = 0;
        int some = 0;
        foreach(var i in sArr)
        {
            if(i.Contains("x"))
            {
                xNum++;
                if(i.Length > 1)
                {
                    num += int.Parse(i.Replace("x", "")) - 1;
                }
            }
            else
            {
                if(Int32.TryParse(i, out int j))
                {
                    some += j;
                }
            }
        }
        
        if(xNum+num == 0)
        {
            answer = $"{some}";
        }
        else if(some == 0)
        {
            if(xNum + num == 1)
            {
                return "x";
            }
            answer = $"{xNum+num}x";        
        }
        else
        {
            if(xNum + num == 1)
            {
                return $"x + {some}";
            }
            answer = $"{xNum+num}x + {some}";
        }
        return answer;
    }
}