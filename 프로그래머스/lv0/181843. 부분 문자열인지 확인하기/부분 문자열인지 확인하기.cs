using System;

public class Solution {
    public int solution(string my_string, string target) {
        int answer = 0;
        bool b = my_string.Contains(target);
        answer = b ? 1 : 0;
        return answer;
    }
}