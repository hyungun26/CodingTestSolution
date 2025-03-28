using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            string[] sArr = Console.ReadLine().Split(" ");
            List<int> list = new List<int>();
            int[] iArr = new int[sArr.Length];
            iArr[0] = int.Parse(sArr[0]);
            iArr[1] = int.Parse(sArr[1]);
            for(int i = 1; i <= iArr[0]; i++)
            {
                if (iArr[0] % i == 0)
                    list.Add(i);
            }

            if(list.Count < iArr[1])           
                Console.Write(0);                            
            else            
                Console.WriteLine(list[iArr[1] - 1]);
        }
    }
}
