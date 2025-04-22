using System;
using System.Collections.Generic;
using System.Linq;

namespace baejoon_28702
{
    class FizzBuzz
    {        
        static void Main()
        {
            List<string> list = new List<string>();
            for(int i = 0; i < 3; i++)
            {
                list.Add(Console.ReadLine());
            }
            int num = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (int.TryParse(list[i].Trim(), out int id))
                {                    
                    num = i;
                }
            }
            int answer = int.Parse(list[num]);
            for(int i = num; i < 3; i++)
            {
                answer += 1;
            }            
            
            if (answer % 5 == 0 && answer % 3 == 0)
                Console.WriteLine("FizzBuzz");
            else if (answer % 5 == 0)
                Console.WriteLine("Buzz");
            else if (answer % 3 == 0)
                Console.WriteLine("Fizz");
            else
                Console.WriteLine(answer);            
        }
    }
}