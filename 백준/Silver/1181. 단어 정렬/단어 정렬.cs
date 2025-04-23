using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace baejoon_1181
{
    class 단어_정렬
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < input; i++)
            {
                list.Add(Console.ReadLine());
            }
            list = list.Distinct().ToList(); // 중복제거
            list.Sort();
            list = list.OrderBy(x => x.Length).ToList();
            
            foreach (var i in list)
            {
                Console.Write(i + "\n");
            }
        }
    }
}