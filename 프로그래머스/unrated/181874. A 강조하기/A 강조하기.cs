using System;
using System.Linq;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        var s = myString.Select(c => c == 'a' ? char.ToUpper(c) : char.ToLower(c));
        s = s.Select(c => c == 'a' ? char.ToUpper(c) : c);
        answer = new String(s.ToArray());
        return answer;
    }
}