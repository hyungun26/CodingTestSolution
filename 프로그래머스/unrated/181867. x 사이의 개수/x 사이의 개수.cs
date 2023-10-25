using System;

public class Solution {
    public int[] solution(string myString) {
        string[] sArr = myString.Split("x");
        int[] answer = new int[sArr.GetLength(0)];
        for(int i = 0; i < sArr.Length; i++)
        {
            answer[i] = sArr[i].Length;
        }
        return answer;
    }
}