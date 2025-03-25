using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            double arg = 0;
            double arg2 = 0;
            for (int i = 0; i < 20; i++)
            {
                string s = Console.ReadLine();
                string[] schar = s.Split(" ");
                float num = 0;
                //A +,A0,B +,B0,C +,C0,D +,D0,F,P
                switch (schar[2])
                {
                    case "A+": 
                        num = 4.5f;
                        break;
                    case "A0":  
                        num = 4f;
                        break;
                    case "B+":
                        num = 3.5f;
                        break;
                    case "B0":
                        num = 3f;
                        break;
                    case "C+":
                        num = 2.5f;
                        break;
                    case "C0":
                        num = 2f;
                        break;
                    case "D+":
                        num = 1.5f;
                        break;
                    case "D0":
                        num = 1f;
                        break;
                    case "F":
                        num = 0f;
                        break;
                    default:
                        continue;
                }
                arg += (num * float.Parse(schar[1]));
                arg2 += float.Parse(schar[1]);
            }
            Console.WriteLine(arg/arg2);
        }        
    }
}
