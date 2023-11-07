using System;

public class Solution {
    public bool solution(bool x1, bool x2, bool x3, bool x4) {
        bool answer = true;
        bool check = true;
        answer = x1 ? true : x2 ? true : false;
        check = x3 ? true : x4 ? true : false;
        answer = !answer ? false : !check ? false : true; 
        return answer;
    }
}