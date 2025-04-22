using System;

namespace baejoon_15964
{
    class 이상한_기호
    {        
        static void Main()
        {
            long[] iArr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            Console.WriteLine((iArr[0] + iArr[1]) * (iArr[0] - iArr[1]));
        }
    }
}