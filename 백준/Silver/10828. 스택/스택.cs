using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace baekjoon10828
{
    class Stack
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int[] stack = new int[num];
            int stackC = 0;
            for (int i = 0; i < num; i++)
            {
                string[] s = Console.ReadLine().Split();
                
                switch (s[0])
                {
                    case "push":                        
                        stack[stackC++] = int.Parse(s[1]);
                        break;
                    case "pop":
                        if(stackC > 0) //stack안에 값이 있다는 뜻
                        {
                            Console.Write(stack[stackC-1] + "\n");
                            stack[stackC--] = 0;                            
                        }
                        else
                            Console.Write(-1 + "\n");
                        break;
                    case "size":
                            Console.Write(stackC + "\n");
                        break;
                    case "empty":
                        if (stackC > 0)
                            Console.Write(0 + "\n");
                        else
                            Console.Write(1 + "\n");
                            break;
                    case "top":
                        if (stackC > 0)
                            Console.Write(stack[stackC - 1] + "\n");
                        else
                            Console.Write(-1 + "\n");
                        break;
                }
            }
        }
    }
}
