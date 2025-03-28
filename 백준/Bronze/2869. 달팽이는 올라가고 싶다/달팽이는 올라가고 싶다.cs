using System;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            string[] value = Console.ReadLine().Split(" ");
            int[] iArr = new int[3];

            for(int i = 0; i < value.Length; i++) 
            {
                iArr[i] = Int32.Parse(value[i]);
            }

            double result = (double)(iArr[2] - iArr[0]) / (double)(iArr[0] - iArr[1]);            
            result = Math.Ceiling(result) + 1;
            Console.WriteLine(result);
        }
    }
}
