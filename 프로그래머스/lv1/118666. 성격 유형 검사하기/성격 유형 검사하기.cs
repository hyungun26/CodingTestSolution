using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        
        Dictionary<char, int> dict = new Dictionary<char, int>
        {
            {'R', 0}, {'T', 0}, {'C', 0}, {'F', 0},
            {'J', 0}, {'M', 0}, {'A', 0}, {'N', 0},
        };
        
        for(int i = 0; i < survey.Length; i++)
        {
            if(choices[i] < 4)
                dict[survey[i][0]] += (choices[i] * 3) % 4;
            else
                dict[survey[i][1]] += (choices[i]) % 4;
        };
            
        answer += dict['R'] >= dict['T'] ? 'R' : 'T';
        answer += dict['C'] >= dict['F'] ? 'C' : 'F';
        answer += dict['J'] >= dict['M'] ? 'J' : 'M';
        answer += dict['A'] >= dict['N'] ? 'A' : 'N';
        return answer;
    }
}