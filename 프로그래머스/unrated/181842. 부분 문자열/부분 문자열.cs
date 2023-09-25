using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0;
        answer = str2.Contains(str1) ? 1 : 0;
        return answer;
    }
}