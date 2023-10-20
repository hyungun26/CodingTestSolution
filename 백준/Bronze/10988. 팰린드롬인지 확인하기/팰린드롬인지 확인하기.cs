using System;

class Baek10988
{
    static void Main()
    {
        string input = Console.ReadLine();        
        int count = 0;
        for(int i = 0; i < input.Length / 2; i++)
        { 
            if (input[i] == input[input.Length - 1 - i])
            {
                count++;
            }
        }
        int answer = count == input.Length / 2 ? 1 : 0;
        Console.WriteLine(answer);
    }
}