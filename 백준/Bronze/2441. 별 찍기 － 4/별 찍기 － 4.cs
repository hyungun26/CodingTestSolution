using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = i; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}