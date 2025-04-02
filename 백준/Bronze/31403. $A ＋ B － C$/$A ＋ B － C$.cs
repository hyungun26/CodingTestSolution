using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace baekjoon10828
{
    class Stack
    {
        static void Main()
        {
            List<int> list = new List<int>();
            for(int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                list.Add(num);
            }
            Console.Write(list[0] + list[1] - list[2] + "\n");
            string s = (list[0].ToString() + list[1].ToString());            
            Console.Write(int.Parse(s) - list[2] + "\n");
        }
    }
}
