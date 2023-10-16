using System;

public class Solution {
    public string solution(string[] str_list, string ex) {
        string answer = "";
        for(int i = 0; i < str_list.Length; i++)
        {
            if(str_list[i].Contains(ex))
                str_list[i] = str_list[i].Replace(str_list[i], "");
            answer+=str_list[i];
        }

        return answer;
    }
}