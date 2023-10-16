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
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (n + n - 1) - (i * 2); j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for (int i = 2; i <= n; i++)
            {
                int count = 0;
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = n - i; j < n; j++)
                {
                    Console.Write("*");
                    count++;
                }
                for (int j = 0; j < (count * 2) / 2 - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}