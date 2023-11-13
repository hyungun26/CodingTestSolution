using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[52];
        my_string.ToLower();
        int num = 0;
        for(int i = 0; i < my_string.Length; i++)
        {
            if(char.IsUpper(my_string[i])) //대문자면
                num = my_string[i] % 65;
            else
                num = my_string[i] % 71;
            answer[num]++;
        }
        return answer;
    }
}