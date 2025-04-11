using System;
using System.Collections.Generic;
using System.Collections;

namespace baekjoon_2587
{
    class  대표값2
    {
        static void Main()
        {
            List<int> ints = new List<int>();
            for(int i = 0; i < 5; i ++)
            {
                ints.Add(int.Parse(Console.ReadLine()));
            }            
            ints.Sort();
            Console.WriteLine(ints.Average());            
            Console.WriteLine(ints[ints.Count / 2]);                                        
        }
    }
}
