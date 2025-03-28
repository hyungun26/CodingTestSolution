using System;
using System.Collections.Generic;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string s = Console.ReadLine();
                s = s.ToLower();
                Console.WriteLine(s);
            }
        }
    }
}
