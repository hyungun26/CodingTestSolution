using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.GetLength(0)];
        for(int i = 0; i < quiz.GetLength(0); i++)
        {
            int num = 0;
            string[] sArr = quiz[i].Split();
            switch(sArr[1])
            {
                case "+" : num = int.Parse(sArr[0]) + int.Parse(sArr[2]);
                    break;
                case "-" : num = int.Parse(sArr[0]) - int.Parse(sArr[2]);
                    break;
            }
            if(num == int.Parse(sArr[4]))
                answer[i] = "O";
            else
                answer[i] = "X";
        }
        return answer;
    }
}