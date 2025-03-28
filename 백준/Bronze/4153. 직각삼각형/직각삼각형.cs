using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading.Channels;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            string[] sArr = new string[3];
            List<double> list = new List<double>();
            while (true)
            {
                sArr = Console.ReadLine().Split();
                if (int.Parse(sArr[0]) == 0 && int.Parse(sArr[1]) == 0 && int.Parse(sArr[2]) == 0)
                    break;
                foreach (string s in sArr)
                {
                    list.Add(int.Parse(s));
                }
                list.Sort();
                if (Math.Pow(list[2], 2) == Math.Pow(list[0], 2) + Math.Pow(list[1], 2))
                    Console.WriteLine("right");
                else
                    Console.WriteLine("wrong");
                list.Clear();
            }                        
        }
    }
}
