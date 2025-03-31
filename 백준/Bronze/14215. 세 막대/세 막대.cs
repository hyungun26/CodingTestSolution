using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {            
            List<int> list = new List<int>();
            string[] s = Console.ReadLine().Split();
            list.Add(int.Parse(s[0]));
            list.Add(int.Parse(s[1]));
            list.Add(int.Parse(s[2]));
            list.Sort();
            if (list.Max() < list[0] + list[1]) //정상 적인 삼각형
            {
                Console.WriteLine(list.Sum());
            }
            else
            {
                list[2] = list[0] + list[1] - 1;
                Console.WriteLine(list.Sum());
            }
        }
    }
}
