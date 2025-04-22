using System;

namespace baejoon_2744
{
    class 대소문자_바꾸기
    {        
        static void Main()
        {
            string s = Console.ReadLine();
            char[] cArr = s.ToCharArray();
            for(int i = 0; i < cArr.Length; i++)
            {
                if (cArr[i] <= 90)
                    cArr[i] = (char)((int)cArr[i] + 32);
                else
                    cArr[i] = (char)((int)(cArr[i] - 32));
            }
            s = "";
            foreach(var i in cArr)
            {
                s += i;
            }
            Console.WriteLine(s);
        }
    }
}