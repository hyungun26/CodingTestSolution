using System;
using System.Collections.Generic;
using System.Linq;

namespace baekjoon_solution
{
    class _24262
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            for(int i = 0; i < num; i++)
            {
                int a = i;
                int slash = 10;
                while (a > 0)
                {
                    list.Add(a % slash);
                    a -= list[list.Count - 1];
                    a = a / 10;                    
                }
                if (num == i + list.Sum())
                {
                    list2.Add(i);
                }
                list.Clear();
            }
            if(list2.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(list2.Min());
        }
    }
}
