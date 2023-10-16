using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int count = 0;
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    count++;
                }
                for (int j = 0; j < (n*2) - (count*2); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = n-1; i > 0; i--)
            {
                int count = 0;
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    count++;
                }
                for (int j = 0; j < (n * 2) - (count * 2); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}