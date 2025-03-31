using System;
using System.Collections.Generic;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());            
            int count = 0;
            bool check = false;
            //num은 무조건 5이상이라고 가정하고 풀어보자
            while(num > 0)
            {
                if(num % 5 == 0 || num % 3 == 0)
                {
                    check = true;
                }
                if (num % 5 == 0)
                {
                    count += num / 5;
                    num -= 5 * (num / 5);                    
                    break;
                }
                num -= 3;
                count++;
            }

            if(!check)
            {
                Console.WriteLine(-1);
                return;
            }
            Console.WriteLine(count);
        }
    }
}
