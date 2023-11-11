using System;

public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        string s = numbers.Replace("one", "1");
        s = s.Replace("two", "2");
        s = s.Replace("three", "3");
        s = s.Replace("four", "4");
        s = s.Replace("five", "5");
        s = s.Replace("six", "6");
        s = s.Replace("seven", "7");
        s = s.Replace("eight", "8");
        s = s.Replace("nine", "9");
        s = s.Replace("zero", "0");
        answer = Int64.Parse(s);
        return answer;
    }
}