using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        bool asdf = false;
        int problem = 0;
        int[] answer = new int[2];
        string s = words[0];
        List<string> list = new List<string>();
        list.Add(words[0]);
        for(int i = 0; i < words.Length-1; i++)
        {
            if(list[i][list[i].Length-1] == words[i+1][0])//끝말이 다음단어의 첫말과 같은지 검사
            {
                //이곳 검사방식을 바꿔봅시다.
                bool check = true;
                for(int j = 0; j < list.Count; j++)
                {
                    if(list[j] == words[i+1])
                    {
                        problem = i + 2;
                        Console.Write($"{i+2}번째에서 문제발생"); 
                        check = false;
                        asdf = true;
                        break;
                    }
                }
                if(check)
                {   
                    list.Add(words[i+1]);
                }
            }
            else
            {
                problem = i + 2;
                break;
            }
            if(asdf)
                break;
        }
        if(problem == 0)
            return answer;
        int num = problem % n;
        float numf = (float)problem / (float)n;
        if(num == 0)
            num = n;
        answer[0] = num;
        answer[1] = (int)Math.Ceiling(numf);
        return answer;
    }
}