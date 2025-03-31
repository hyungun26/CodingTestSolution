using System;
using System.Collections.Generic;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            List<long> list = new List<long>();
            for (long i = 0; i < 3; i++)
            {
                list.Add(long.Parse(Console.ReadLine()));
            }            
            int[] iArrCount = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            long num = list[0] * list[1] * list[2];
            string s = num.ToString();            
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < s.Length; j++)
                {
                    
                    if (i == (int)(s[j]) - 48)
                    {
                        iArrCount[i]++;
                    }
                }
            }
            foreach (var i in iArrCount)
            {
                Console.WriteLine(i);
            }
        }
    }
}
