using System;
using System.Collections.Generic;
using System.Security;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();
            double A = double.Parse(s[0]);
            double B = double.Parse(s[1]);
            double result = 0;
            if(A < 0 && B < 0)
            {
                result = A - B;
            }
            else if(A > 0 && B > 0) 
            { 
                result = A - B; 
            }
            else            
                result = Math.Abs(A) + Math.Abs(B);
            Console.WriteLine(Math.Abs(result));
        }
    }
}
