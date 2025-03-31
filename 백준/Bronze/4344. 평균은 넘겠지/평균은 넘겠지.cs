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
                double sum = 0;
                double count = 0;
                string[] sArr = Console.ReadLine().Split();
                double summary = int.Parse(sArr[0]);
                for (int j = 1; j <= summary; j++)
                {                    
                    sum += double.Parse(sArr[j]);                    
                }
                sum = sum / summary;
                sum = Math.Round(sum, 3);
                for (int j = 1; j <= summary; j++)
                {
                    if (sum < double.Parse(sArr[j]))
                        count++;
                }
                count /= summary;
                count *= 100;
                count = Math.Round(count, 3);
                string s = count.ToString();
                if(s.Length < 6)
                {
                    if(s.Length < 3)
                    {
                        s += ".";
                    }
                    s = s.PadRight(6, '0');
                }
                Console.WriteLine(s + "%");
            }
        }
    }
}
