using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {            
            int count = Int32.Parse(Console.ReadLine());
            string[] sArr = Console.ReadLine().Split(" ");
            int[] iArr = new int[count];
            int result = 0;       
                       
            for(int i = 0; i < count; i++)
            {
                iArr[i] = Int32.Parse(sArr[i]);
            }

            for (int i = 0; i < count; i++)
            {
                bool check = false;
                for (int j = 2; j < iArr[i]; j++)
                {
                    if (iArr[i] % j == 0)
                    {
                        check = true;
                        break;
                    }

                }
                if (!check && iArr[i] != 1)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
