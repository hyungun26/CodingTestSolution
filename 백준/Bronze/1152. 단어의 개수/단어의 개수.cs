using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            List<string> list = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != "")
                {                     
                    list.Add(s[i]);
                }
            }
            Console.WriteLine(list.Count);
        }
    }
}