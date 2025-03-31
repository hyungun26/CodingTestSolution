using System;
using System.Collections.Generic;
using System.Data;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            string[] nums = Console.ReadLine().Split();
            int x = int.Parse(nums[0]); 
            int y = int.Parse(nums[1]); 
            int w = int.Parse(nums[2]); 
            int h = int.Parse(nums[3]); 
            List<int> list = new List<int>();            
            list.Add(x);
            list.Add(y);
            list.Add(w - x);
            list.Add(h - y);

            Console.WriteLine(list.Min());
        }
    }
}
