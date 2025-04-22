using System;

namespace baejoon_15964
{
    class 이상한_기호
    {        
        static void Main()
        {
            int[] iArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine((iArr[0] + iArr[1]) * (iArr[0] - iArr[1]));
        }
    }
}