using System;
using System.Collections.Generic;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < num; i++)
            {
                int sum = 0;
                int point = 0;
                string s = Console.ReadLine();
                for(int j = 0; j < s.Length; j++)
                {
                    if (s[j] == 'O')
                    {
                        sum += ++point;                        
                    }
                    else
                    {
                        point = 0;
                    }                    
                }
                Console.WriteLine(sum);
            }            
        }
    }
}
