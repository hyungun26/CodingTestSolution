using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {            
            List<int> list = new List<int>();
            int result = 0;
            bool check = true;
            while(check)
            {
                result = Int32.Parse(Console.ReadLine());
                if (result == -1)
                    return;

                for (int i = 1; i <= result; i++)
                {
                    if (result % i == 0)
                        list.Add(i);
                }
                int num = 0;
                string s = "";
                for (int i = 0; i < list.Count - 1; i++)
                {
                    num += list[i];
                    s += list[i] + " + ";
                }
                if (num == result)
                {
                    s = s.Remove(s.Length - 1);
                    s = s.Remove(s.Length - 1);
                    Console.WriteLine($"{result} = " + s);
                }
                else
                    Console.WriteLine($"{result} is NOT perfect.");
                list.Clear();
            }            
        }
    }
}
