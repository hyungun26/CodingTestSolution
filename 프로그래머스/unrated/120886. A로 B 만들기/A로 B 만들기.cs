using System;
using System.Linq;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        char[] cArr = before.ToCharArray();
        char[] cArr2 = after.ToCharArray();
        Array.Sort(cArr);
        Array.Sort(cArr2);
        if(new string(cArr2) == new string(cArr))
            return 1;
        return answer;
    }
}