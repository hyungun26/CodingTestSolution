using System;
public class Solution {
    public bool solution(int x) {
        bool answer = false;
        int num = 1;
        int count = 1;
        int xx = x;
        int Correct = 0;
        while(true)
        {
            if(x / num >= 10)
            num *= 10;
            else
            {
                break;
            }
            count++;
        }
        
        Console.Write(num);
        
        for(int i = 0; i < count; i++)
        {
            Correct += xx/num;
            int a = xx/num;
            xx -= a * num;
            num /= 10;
        }
        
        
        if(x % Correct == 0)
            return answer = true;
            
        return answer;
    }
}