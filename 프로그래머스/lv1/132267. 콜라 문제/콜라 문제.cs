using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int num = 0;        
        while(n != 0)
        {
            answer += b * (n / a);//총 바꿔먹은양
            num += n % a; // 못바꿔먹은 양
            n = b * (n / a);
            if(n + num / a >= 1)
            {
                n += num;
                num = 0;
            }
        }
        return answer;
    }
}