using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        if(my_string.Length < is_suffix.Length) return 0;
        string s = my_string.Substring(my_string.Length-is_suffix.Length,is_suffix.Length);
        return is_suffix == s ? 1 : 0;
    }
}