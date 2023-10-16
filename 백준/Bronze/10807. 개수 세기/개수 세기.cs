using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();
            string find = Console.ReadLine();

            int result = Array.FindAll(str, x => x == find).Length;
            Console.WriteLine(result);
        }
    }
}