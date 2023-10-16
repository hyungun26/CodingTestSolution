using System;
using System.Collections.Generic;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Enumerable.Range(1, 30).ToList();
            for(int i = 0; i < 28; i++)
            {
                int num = int.Parse(Console.ReadLine());
                list.Remove(num);
            }
            list.Sort();
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
        }
    }
}