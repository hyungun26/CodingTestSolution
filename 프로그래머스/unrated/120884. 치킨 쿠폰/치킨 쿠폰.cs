using System;

public class Solution {
    public int solution(int chicken) {
        int answer = 0;
        int num = 0;
        while(chicken >= 10)
        {
            int a = chicken / 10; //쿠폰을 사용한 개수
            int some = chicken % 10;
            chicken = a + some;
            num += a;
        }
        
        return num;
    }
}