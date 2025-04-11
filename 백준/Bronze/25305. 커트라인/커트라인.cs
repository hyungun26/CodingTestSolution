using System;
using System.Collections.Generic;
using System.Collections;

namespace baekjoon_25305
{
    class  커트라인
    {
        static void Main()
        {
            List<int> ints = new List<int>();
            int[] iArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);            
            ints = (Array.ConvertAll(Console.ReadLine().Split(), int.Parse).ToList());
            ints = ints.OrderByDescending(i => i).ToList();
            Console.WriteLine(ints[iArr[1]-1]);
        }
    }
}
