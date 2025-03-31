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
            while (true)
            {
                string[] s = Console.ReadLine().Split();
                list.Add(int.Parse(s[0]));
                list.Add(int.Parse(s[1]));
                list.Add(int.Parse(s[2]));
                list.Sort();
                if (list[0] == 0 && list[1] == 0 && list[2] == 0)
                    return;
                
                if (list[0] == list[1] && list[1] == list[2]) // 다 같으면 //무조건 맞음
                {
                    Console.WriteLine("Equilateral");
                }
                else if (list[0] == list[1] || list[1] == list[2] || list[0] == list[2]) //2개만 같으면
                {
                    if (list[0] >= list[1] + list[2] || list[1] >= list[0] + list[2] || list[2] >= list[0] + list[1])
                        Console.WriteLine("Invalid");
                    else
                        Console.WriteLine("Isosceles");
                }
                else if (list.Max() < list[0] + list[1])
                {
                    Console.WriteLine("Scalene");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
                list.Clear();
            }
        }
    }
}
