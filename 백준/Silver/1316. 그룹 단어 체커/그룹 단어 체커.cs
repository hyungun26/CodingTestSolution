using System;

namespace Baek2941
{
    class Solution
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < num; i++)
            {
                string s = Console.ReadLine();
                bool check = false;
                for (int j = 0; j < s.Length-1; j++)
                {
                    
                    if (s[j] != s[j+1])//이 조건안에서 해결을하면 끝
                    {
                        for(int k = 0; k < j; k++)
                        {
                            if (s[k] == s[j + 1])
                                check = true;
                        }
                    }
                }
                if (!check) count++;
            }
            Console.WriteLine(count);
        }
    }
}