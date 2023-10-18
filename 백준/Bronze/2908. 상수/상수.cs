using System;

class Baek2908
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        string a = s[0];
        string b = s[1];
        char[] c = a.ToCharArray();
        c = c.Reverse().ToArray();
        char[] d = b.ToCharArray();
        d = d.Reverse().ToArray();

        a = "";
        b = "";
        for (int i = 0; i < c.Length; i++)
        {
            a += c[i];
            b += d[i];
        }
        int w = int.Parse(a);
        int q = int.Parse(b);
        int answer = w > q ? w : q;
        Console.Write(answer);
    }
}