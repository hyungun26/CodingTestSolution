using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] token = input.Split();

            long a = long.Parse(token[0]);
            long b = long.Parse(token[1]);
            long c = long.Parse(token[2]);

            Console.WriteLine(a + b + c);
        }
    }
}