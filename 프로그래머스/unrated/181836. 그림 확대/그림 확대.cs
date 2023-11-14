using System;

public class Solution {
    public string[] solution(string[] picture, int k) {
        string[] answer = new string[picture.Length*k];
        int num = 0;
        for(int i = 0; i < picture.Length; i++)
        {
            for(int j = 0; j < k; j++)
            {
                for(int l = 0; l < picture[i].Length; l++)
                {
                    for(int o = 0; o < k; o++)
                    {
                        answer[num] += picture[i][l];
                    }
                }
                num++;
            }
        }
        return answer;
    }
}