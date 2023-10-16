using System;
using System.Collections.Generic;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            List<float> list = new List<float>();
            for(int i = 0; i < s.GetLength(0); i++)
            {
                list.Add(int.Parse(s[i]));
            }
            float num = list.Max();
            for(int i = 0; i < list.Count; i++)
            {
                list[i] = list[i] / num * 100;
            }
            
            Console.WriteLine(list.Sum()/list.Count);
        }
    }
}