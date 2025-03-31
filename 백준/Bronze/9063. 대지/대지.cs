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
            int num = int.Parse(Console.ReadLine());
            List<int> width = new List<int>();
            List<int> height = new List<int>();
            for (int i = 0; i < num; i++)
            {
                string[] s = Console.ReadLine().Split();
                width.Add(int.Parse(s[0]));
                height.Add(int.Parse(s[1]));
            }
            int w = width.Max() - width.Min();
            int h = height.Max() - height.Min();
            Console.WriteLine(w*h);
        }
    }
}
