using System;
using System.Reflection.Metadata.Ecma335;

namespace baejoon_1259
{
    class 팰린드롬수
    {        
        static void Main()
        {
            while(true)
            {
                string s = Console.ReadLine();
                if (s == "0")
                    return;

                char[] cArr = s.ToCharArray();
                int reverse = cArr.Length - 1;
                for (int i = 0; i < cArr.Length / 2; i++)
                {
                    if (cArr[i] == cArr[reverse] && i == cArr.Length  / 2 -1)
                    {
                        Console.WriteLine("yes");
                    }
                    if(cArr[i] != cArr[reverse])
                    {
                        Console.WriteLine("no");
                        break;
                    }
                    reverse--;
                }
                if(s.Length == 1)
                    Console.WriteLine("yes");
            }            
        }
    }
}