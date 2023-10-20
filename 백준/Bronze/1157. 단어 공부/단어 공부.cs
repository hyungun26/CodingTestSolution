using System;

class Baek1157
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.ToUpper();
        char[] cArr = input.ToCharArray();
        cArr = cArr.Distinct().ToArray();
        int[] iArr = new int[cArr.Length];
        for(int i = 0; i < cArr.Length; i++)
        {
            for(int j = 0; j < input.Length; j++)
            {
                if(cArr[i] == input[j])
                {
                    iArr[i]++;
                }
            }
        }
        int bigNum = iArr.Max();
        int indexNum = 0;
        int distinct = 0;
        for(int i = 0; i < iArr.Length; i++)
        {
            if (iArr[i] == bigNum)
            {
                indexNum = i;
                distinct++;
            }
        }
        char c = distinct > 1 ? '?' : cArr[indexNum];
        Console.WriteLine(c);
    }
}