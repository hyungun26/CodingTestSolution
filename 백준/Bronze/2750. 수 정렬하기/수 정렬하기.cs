using System;
using System.Collections.Generic;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {

            int num = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < num; i++)
            {
                int a = int.Parse(Console.ReadLine());
                list.Add(a);
            }               
            list.Sort();
            foreach (int a in list)
            {
                Console.WriteLine(a);
            }
        }
    }
}
