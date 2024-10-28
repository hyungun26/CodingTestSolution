using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string word) {
        int answer = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        map.Add('A', 0); map.Add('E', 1); map.Add('I', 2); map.Add('O', 3); map.Add('U', 4);
        int[] num = {781, 156, 31, 6, 1};
        for(int i = 0; i < word.Length; i++)
        {
            answer += map[word[i]] * num[i];
        }
        return answer + word.Length;
    }
}