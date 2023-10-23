using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        char[] arr = myString.ToCharArray();
        myString = "";
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 'A')
            {
                arr[i] = 'B';
            }
            else
                arr[i] = 'A';
            myString += arr[i];
        }
        if(myString.Contains(pat))
            answer = 1;
        else
            answer = 0;
        return answer;
    }
}