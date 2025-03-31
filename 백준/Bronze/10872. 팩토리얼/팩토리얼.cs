using System;
using System.Collections.Generic;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {

            long num = long.Parse(Console.ReadLine());
            long sum = 1;
            for (long i = num; i > 0; i--)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
