using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {            
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i > 0; i--)
            {
                Console.Write(i+"\n");
            }
        }
    }
}
