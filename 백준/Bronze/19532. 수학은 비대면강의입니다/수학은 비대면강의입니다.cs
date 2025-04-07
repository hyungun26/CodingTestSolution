using System;
using System.Collections.Generic;
using System.Linq;

namespace baekjoon_19532
{
    class 수학은비대면강의입니다
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            int d = int.Parse(s[3]);
            int e = int.Parse(s[4]);
            int f = int.Parse(s[5]);
            List<int> list = new List<int>();
            list.Add(100); list.Add(100);
            for (int i = 0; i < 1000; i++)
            {
                int num = -i;
                for (int j = 0; j < 1000; j++)
                {
                    int num2 = -j;
                    if (a * i + b * j == c && d * i + e * j == f)
                    {
                        list.Clear();
                        list.Add(i);
                        list.Add(j);
                        Console.WriteLine(list[0] + " " + list[1]);
                        return;
                    }
                                        
                    if (a * num + b * j == c && d * num + e * j == f)
                    {
                        list.Clear();
                        list.Add(num);
                        list.Add(j);
                        Console.WriteLine(list[0] + " " + list[1]);
                        return;
                    }

                    if (a * i + b * num2 == c && d * i + e * num2 == f)
                    {
                        list.Clear();
                        list.Add(i);
                        list.Add(num2);
                        Console.WriteLine(list[0] + " " + list[1]);
                        return;
                    }

                    if (a * num + b * num2 == c && d * num + e * num2 == f)
                    {
                        list.Clear();
                        list.Add(num);
                        list.Add(num2);
                        Console.WriteLine(list[0] + " " + list[1]);
                        return;
                    }
                }
            }
        }
    }
}
