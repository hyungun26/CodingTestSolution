using System;
public class Solution {
    public bool solution(string s) {
        if(s.Length == 4 || s.Length == 6)
        {
            
        }
        else
            return false;
        if(Int32.TryParse(s, out int j))
            return true;
        else
            return false;
    }
}