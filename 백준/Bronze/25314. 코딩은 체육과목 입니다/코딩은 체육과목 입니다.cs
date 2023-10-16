using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for(int i = 0; i < input; i+=4)
            {
                Console.Write("long ");
            }
            Console.Write("int");
        }
    }
}