using System;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            int count = Int32.Parse(Console.ReadLine());            
            int[] cash = new int[count];
            int[,] iArr = new int[count,4];
            for (int i = 0; i < count; i++)
            {
                cash[i] = Int32.Parse(Console.ReadLine());
                while (cash[i] != 0)
                {
                    if(cash[i] >= 25)
                    {
                        iArr[i, 0] = cash[i] / 25;
                        cash[i] = cash[i] % 25;
                    }
                    else if(cash[i] >= 10)
                    {
                        iArr[i, 1] = cash[i] / 10;
                        cash[i] = cash[i] % 10;
                    }
                    else if(cash[i] >= 5)
                    {
                        iArr[i, 2] = cash[i] / 5;
                        cash[i] = cash[i] % 5;
                    }
                    else
                    {
                        iArr[i, 3] = cash[i] / 1;
                        cash[i] = cash[i] % 1;
                    }
                }
            }
            for (int i = 0; i < iArr.GetLength(0); i++)
            {
                for (int j = 0; j < iArr.GetLength(1); j++)
                {
                    Console.Write(iArr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
