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
            char[] cArr = sArr[0].ToCharArray();
            int num = 0;
            int sum = 0;
            int pass = cArr.Length - 1;
            for (int i = cArr.Length -1;  i >= 0; i--)
            {
                if ((int)cArr[i] - 55 >= 10)
                {
                    //알파벳
                    int alp = (int)cArr[i] - 55;
                    if (pass == i)
                    {
                        sum += alp;
                    }
                    else
                    {
                        
                        sum += alp * Square(num, sArr);
                    }
                }
                else
                {
                    sum += ((int)cArr[i] - 48) * Square(num, sArr);
                }
                num++;
            }

            Console.WriteLine(sum);
        }

        public static int Square(int num, string[] sArr)
        {
            int a = 1;
            for (int j = 0; j < num; j++)
            {
                a *= (Int32.Parse(sArr[1]));
            }
            return a;
        }
    }
}
