using System;

public class Solution {
    public int solution(int a, int b, int c) {
        int answer = 0;
        int num = a+b+c;
        int num2 = a*a+b*b+c*c;
        
        if(a == b)
        {
            if(a == c) //다 같을때
            {
                answer = num * num2 * (a*a*a+b*b*b+c*c*c);    
                return answer;
            }
            if(a != c)
            {
                answer = num * num2;
            }
            else if(b != c)
            {
                answer = num * num2;
            }
        }
        else if(a == c)
        {
            if(a != b)
            {
                answer = num * num2;
            }
            else if(a != c)
            {
                answer = num * num2;
            }
        }
        else if(c == b)
        {
            if(a != b)
            {
                answer = num * num2;
            }
            else if(a != c)
            {
                answer = num * num2;
            }
        }
        else
        {
            answer = num;
        }
        return answer;
    }
}