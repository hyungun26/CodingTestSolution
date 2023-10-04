using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        List<double> list = new List<double>();
        //[a-b, c-d],[a-c, b-d],[a-d, b-c]
        double b = Math.Abs(dots[0,0] - dots[1,0]);
        if(b == 0)
            b = 1;
        double a = Math.Abs(dots[0,1] - dots[1,1]);
        list.Add(a/b);
        double c = Math.Abs(dots[2,0] - dots[3,0]);
        if(c == 0)
            c = 1;
        double d = Math.Abs(dots[2,1] - dots[3,1]);
        list.Add(d/c);   
        if(list[0] == list[1])
            return 1;
        
        double bb = Math.Abs(dots[0,0] - dots[2,0]);
        if(bb == 0)
            bb = 1;
        double aa = Math.Abs(dots[0,1] - dots[2,1]);
        list.Add(aa/bb);        
        double cc = Math.Abs(dots[1,0] - dots[3,0]);
        if(cc == 0)
            cc = 1;
        double dd = Math.Abs(dots[1,1] - dots[3,1]);
        list.Add(dd/cc);
        if(list[2] == list[3])
            return 1;
        
        double bbb = Math.Abs(dots[0,0] - dots[3,0]);
        if(bbb == 0)
            bbb = 1;
        double aaa = Math.Abs(dots[0,1] - dots[3,1]);
        list.Add(aaa/bbb);
        double ccc = Math.Abs(dots[1,0] - dots[2,0]);
        if(ccc == 0)
            ccc = 1;
        double ddd = Math.Abs(dots[1,1] - dots[2,1]);
        list.Add(ddd/ccc);
        if(list[4] == list[5])
            return 1;
        
        
        return answer;
    }
}