using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
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
            int a = n - 1;
            for (int i = 0; i < a; i++)
            {  
                Console.Write(" ");
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < (a+a-1) - (i*2); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}