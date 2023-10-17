using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            string[] strArr = new string[num];
            for(int i = 0; i < num; i++)
            {
                string[] s = Console.ReadLine().Split();
                string ss = "";
                int a = s[0][0] % 48;
                int count = 0;
                for(int j = 1; j <= a * s[1].Length; j++)
                {
                    ss += s[1][count];
                    if (j % a == 0)
                        count++;
                }
                strArr[i] = ss;
            }

            foreach (var item in strArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}