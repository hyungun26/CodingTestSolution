using System;

namespace Baek2941
{
    class Solution
    {
        public static void Main()
        {
            string[] s = Console.ReadLine().Split();
            int[,] ints = new int[int.Parse(s[0]), int.Parse(s[1])];
            int[,] ints2 = new int[int.Parse(s[0]), int.Parse(s[1])];
            for (int i = 0; i < ints.GetLength(0) * 2; i++)
            {
                s = Console.ReadLine().Split();
                if(i < ints2.GetLength(0))
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        ints[i, j] = int.Parse(s[j]);
                    }
                }
                else
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        ints2[i-ints.GetLength(0), j] = int.Parse(s[j]);
                    }
                }
            }

            for(int i = 0; i < ints2.GetLength(0); i++)
            {
                for(int j = 0; j < ints2.GetLength(1); j++)
                {
                    ints[i,j] = ints[i,j] + ints2[i,j];
                    Console.Write(ints[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}