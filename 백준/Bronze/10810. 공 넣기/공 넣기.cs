using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            //바구니의 갯수
            string[] basket = Console.ReadLine().Split();
            int N = int.Parse(basket[0]);
            int M = int.Parse(basket[1]);
            int[] intN = new int[N];
            Array.Fill(intN, 0);

            for (int i = 0; i < M; i++)
            {
                string[] num = Console.ReadLine().Split();
                int Start = int.Parse(num[0]);
                int End = int.Parse(num[1]);
                int ballNum = int.Parse(num[2]);
                for (int j = Start - 1; j <= End - 1; j++)
                {
                    intN[j] = ballNum;
                }
            }

            foreach(var i in intN)
            {
                Console.Write(i + " ");
            }
        }
    }
}