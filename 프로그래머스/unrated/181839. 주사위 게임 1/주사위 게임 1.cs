using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        if(a % 2 == 1 && b % 2 == 1)//둘다 홀수 이면
        {
            return a*a + b*b;
        }
        else if((a+b) % 2 == 1)
        {
            return 2*(a+b);
        }
        else
            return Math.Abs(a-b);
    }
}