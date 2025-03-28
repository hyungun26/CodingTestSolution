using System;
using System.Collections.Generic;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            string[] value = new string[2];
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            bool check = true;
            while (check)
            {
                value = Console.ReadLine().Split(" ");
                list[0] = Int32.Parse(value[0]);
                list[1] = Int32.Parse(value[1]);
                if (list[0] == 0 && list[1] == 0)
                    break;
                if (list[1] % list[0] == 0)
                {
                    Console.WriteLine("factor");
                }
                else if (list[0] % list[1] == 0)
                {
                    Console.WriteLine("multiple");
                }                
                else
                {
                    Console.WriteLine("neither");
                }
            }
        }
    }
}
