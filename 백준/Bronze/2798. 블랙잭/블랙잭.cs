using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            List<int> list = new List<int>();
            string[] s = Console.ReadLine().Split();
            int goal = int.Parse(s[1]);
            string[] s2 = Console.ReadLine().Split();
            int result = 0;
            foreach(var i in s2)
            {
                list.Add(int.Parse(i));
            }
            for (int i = 0; i < int.Parse(s[0])-2; i++)
            {
                for(int j = i+1; j < int.Parse(s[0])-1; j++)
                {
                    for(int k = j+1;  k < int.Parse(s[0]); k++)
                    {
                        if (goal >= list[i] + list[j] + list[k])
                        {
                            if(result < list[i] + list[j] + list[k])
                                result = list[i] + list[j] + list[k];
                        }                            
                    }                    
                }
            }
            Console.WriteLine(result);
        }
    }
}
