using System;
using System.Linq;

class Baek11718
{
    static void Main()
    {
        int[,] iArr = new int[9, 9];
        int max = 0, col = 1, ver = 1;
        for(int i = 0; i < 9; i++)
        {
            string[] s = Console.ReadLine().Split();
            for(int j = 0; j < 9; j++)
            {
                iArr[i,j] = Convert.ToInt32(s[j]);
                if (iArr[i, j] > max)
                {
                    max = iArr[i, j];
                    col = i+1;
                    ver = j+1;
                }
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(col + " " + ver);
    }
}