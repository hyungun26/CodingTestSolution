using System;

namespace baejoon_1000
{
    class A_Plus_B
    {        
        static void Main()
        {
            int[] iArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(iArr[0] - iArr[1]);
        }
    }
}