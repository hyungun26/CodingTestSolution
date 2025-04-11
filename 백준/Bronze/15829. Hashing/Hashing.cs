namespace baekjoon_15829
{
    class Hashing
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());     
            string s = Console.ReadLine();
            char[] cArr = s.ToCharArray();
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                int a = cArr[i] - 96;
                for(int j = 0; j < i; j++)
                {
                    a *= 31;
                }                
                sum += a;
            }
            Console.WriteLine(sum);
        }
    }
}
