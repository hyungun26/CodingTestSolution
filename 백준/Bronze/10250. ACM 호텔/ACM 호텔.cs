using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace baekjoon10828
{
    class Stack
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = (int.Parse(s[2]) % int.Parse(s[0])) * 100;
                if(a < 100)
                    a = int.Parse(s[0]) * 100;
                int b = (int.Parse(s[2]) / int.Parse(s[0]));
                if (int.Parse(s[2]) % int.Parse(s[0]) != 0)
                    b += 1;
                Console.WriteLine(a+b);
            }
        }
    }
}
