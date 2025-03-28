using System;
using System.Collections.Generic;
using System.Security;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            int A = 0;
            int B = 0;
            for(int i = 0; i < 2; i++)
            {
                string[] sArr = Console.ReadLine().Split();
                List<int> list = new List<int>();
                int[] iArr = { 6, 3, 2, 1, 2 };
                int sum = 0;
                foreach (string s in sArr)
                {
                    list.Add(int.Parse(s));
                }
                for (int j = 0; j < list.Count; j++)
                {
                    sum += list[j] * iArr[j];
                }
                list.Clear();
                if (i == 0)
                    A = sum;                
                else
                    B = sum;
            }
            Console.WriteLine(A + " " + B);
        }
    }
}
