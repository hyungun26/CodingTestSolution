using System;

namespace Baek10798
{
    class Solution
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            int num = 0;
            string s = "";
            for (int i = 0; i < 5; i++)
            {
                s = Console.ReadLine();
                list.Add(s);
                if (list[i].Length > num)
                    num = list[i].Length;
            }
             s = "";
            for(int i = 0; i < num; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (list[j].Length < i+1)
                    {
                    }
                    else
                        s += list[j][i];
                }
            }
            Console.WriteLine(s);
        }
    }
}