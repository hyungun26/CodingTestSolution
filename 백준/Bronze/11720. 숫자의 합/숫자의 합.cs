using System;
using System.Collections.Generic;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            List<int> list = new List<int>();
            for(int i = 0; i < s.Length; i++)
            {
                list.Add(s[i]%48);
            }

            Console.Write(list.Sum());
        }
    }
}