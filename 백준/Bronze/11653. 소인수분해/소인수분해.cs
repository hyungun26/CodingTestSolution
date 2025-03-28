using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {            
            int num = Int32.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    num = num / i;
                    list.Add(i);
                    i = 1;
                }
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
