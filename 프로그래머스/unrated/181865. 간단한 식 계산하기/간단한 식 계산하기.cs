using System;

public class Solution {
    public int solution(string binomial) {
        int answer = 0;
        string[] sArr = binomial.Split();
        switch(sArr[1])
        {
            case "+" : return int.Parse(sArr[0]) + int.Parse(sArr[2]);
                break;
            case "-" : return int.Parse(sArr[0]) - int.Parse(sArr[2]);
                break;
            case "*" : return int.Parse(sArr[0]) * int.Parse(sArr[2]);
                break;
        }
        return answer;
    }
}