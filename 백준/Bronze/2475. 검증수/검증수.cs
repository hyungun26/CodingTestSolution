using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {            
            string[] sArr = Console.ReadLine().Split();
            List<int> list = new List<int>();
            foreach (var i in sArr)
            {
                list.Add(Int32.Parse(i));
            }
            int sum = 0;
            foreach (var i in list)
            {
                sum += i * i;
            }
            Console.WriteLine(sum % 10);
        }
    }
}
