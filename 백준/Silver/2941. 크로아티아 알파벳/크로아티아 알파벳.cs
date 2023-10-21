using System;

namespace Baek2941
{
    class Solution
    {
        public static void Main()
        {
            string s = Console.ReadLine();
            if(s.Contains("c="))
            {
                s = s.Replace("c=", " ");
            }
            if (s.Contains("c-"))
            {
                s = s.Replace("c-", " ");
            }
            if (s.Contains("dz="))
            {
                s = s.Replace("dz=", " ");
            }
            if (s.Contains("d-"))
            {
                s = s.Replace("d-", " ");
            }
            if (s.Contains("lj"))
            {
                s = s.Replace("lj", " ");
            }
            if (s.Contains("nj"))
            {
                s = s.Replace("nj", " ");
            }
            if (s.Contains("s="))
            {
                s = s.Replace("s=", " ");
            }
            if (s.Contains("z="))
            {
                s = s.Replace("z=", " ");
            }
            Console.WriteLine(s.Length);
        }
    }
}