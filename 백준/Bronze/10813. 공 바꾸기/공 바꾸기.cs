using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int N = int.Parse(s[0]);
            int M = int.Parse(s[1]);
            int[] iArr = Enumerable.Range(1, N).ToArray();
            for(int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                int save = iArr[a - 1];
                iArr[a - 1] = iArr[b - 1];
                iArr[b - 1] = save;
            }
            foreach (var e in iArr)
            {
                Console.Write(e + " ");
            }
        }
    }
}