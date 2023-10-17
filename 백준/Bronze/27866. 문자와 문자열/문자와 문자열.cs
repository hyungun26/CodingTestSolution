using System;
using System.Collections.Generic;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(s[num-1]);
        }
    }
}