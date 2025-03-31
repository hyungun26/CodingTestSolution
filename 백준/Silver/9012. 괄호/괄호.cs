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
                bool check = false;
                int count = 0;
                string s = Console.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '(')
                    {
                        count++;
                    }
                    else
                    {
                        if(count <= 0)
                        {
                            Console.WriteLine("NO");
                            check = true;
                            break;
                        }
                        count--;
                    }
                }
                if(!check)
                {
                    if (count != 0)
                        Console.WriteLine("NO");
                    else
                        Console.WriteLine("YES");
                }                
            }
        }
    }
}
