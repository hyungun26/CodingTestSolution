using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        int answer = 0;
        double f = 0;
        List<int> l = new List<int>();
        l.Add(a);l.Add(b);l.Add(c);l.Add(d);
        l.Sort();
        if(l[0] == l[1] && l[0] == l[2] && l[0] == l[3]) // 다 같으면
        {
            answer = 1111 * a;
        }
        else if(l[0] == l[1] && l[0] == l[2]) // 3개 겹침
        {
            f = Math.Pow(10*l[0] + l[3], 2);
            answer = (int)f;
        }
        else if(l[3] == l[2] && l[3] == l[1]) // 3개 겹침
        {
            f = Math.Pow(10*l[3] + l[0], 2);
            answer = (int)f;
        }
        else if(l[0] == l[1] && l[2] == l[3]) // 2개씩 쌍을 이룸
        {
            answer = (l[0]+l[2]) * Math.Abs(l[0] - l[2]);
        }
        else if(l[0] == l[1] || l[1] == l[2] || l[2] == l[3])
        {
            if(l[0] == l[1])
                answer = l[2] * l[3];
            else if(l[1] == l[2])
                answer = l[0] * l[3];
            else if(l[2] == l[3])
                answer = l[0] * l[1];
        }
        else
        {
            answer = l.Min();
        }
        
        return answer;
    }
}