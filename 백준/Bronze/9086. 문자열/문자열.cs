using System;
using System.Collections.Generic;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for(int i = 0; i < num; i++)
            {
                string s = Console.ReadLine();
                if(s.Length == 1)
                {
                    list.Add($"{s}{s}");
                    continue;
                }
                list.Add($"{s[0]}{s[s.Length-1]}");
            }
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}