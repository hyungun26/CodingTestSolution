using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {            
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                bool check = false;
                for(int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        check = true;
                        break;
                    }
                }
                if(!check && i != 1)
                {
                    list.Add(i);
                }
            }
            if (list.Count == 0)
            {
                Console.WriteLine(-1);
                return;
            }
            Console.WriteLine(list.Sum());
            Console.WriteLine(list[0]);
        }
    }
}
