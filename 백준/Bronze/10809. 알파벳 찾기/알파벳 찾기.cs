using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            int[] iArr = Enumerable.Repeat(-1, 26).ToArray();
            for(int i = 0; i < s.Length; i++)
            {
                if(iArr[s[i] % 97] == -1)
                {
                    iArr[s[i] % 97] = i;
                }
            }
            foreach(var i in iArr)
            {
                Console.Write(i+" ");
            }
        }
    }
}