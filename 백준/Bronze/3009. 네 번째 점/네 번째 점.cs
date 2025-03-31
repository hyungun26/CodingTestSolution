using System;
using System.Collections.Generic;
using System.Data;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            
            List<int> list1 = new List<int>();                    
            List<int> list2 = new List<int>();
            for(int i = 0; i < 3; i++)
            {
                string[] nums = Console.ReadLine().Split();
                list1.Add(int.Parse(nums[0]));
                list2.Add(int.Parse(nums[1]));
            }
            var a = list1.GroupBy(i => i).Where(x => x.Count() < 2).Select(x => x.Key);
            var b = list2.GroupBy(i => i).Where(x => x.Count() < 2).Select(x => x.Key);
            foreach (var i in a)
            {
                Console.Write(i + " ");
            }
            foreach(var i in b)
            {
                Console.WriteLine(i);
            }
        }
    }
}
