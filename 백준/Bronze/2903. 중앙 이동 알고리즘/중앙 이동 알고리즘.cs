using System;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            int count = Int32.Parse(Console.ReadLine());
            int result = 2;            
            for (int i = 0; i < count; i++)
            {
                result = result * 2 - 1;
            }
            Console.WriteLine(result * result);
        }
    }
}
