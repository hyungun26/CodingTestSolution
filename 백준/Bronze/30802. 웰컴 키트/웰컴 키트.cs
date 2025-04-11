namespace baekjoon_30802
{
    class 웰컴_키트
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            double[] size = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
            double[] sum = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
            double num = 0;
            double num2 = 0;
            for(int i = 0; i < 6; i++)
            {
                if(size[i] != 0)
                {
                    num += Math.Ceiling(size[i] / sum[0]);
                }
            }
            num2 = people / sum[1];
            Console.WriteLine(num);
            Console.Write(Math.Truncate(num2));
            num2 = people % sum[1];
            Console.WriteLine(" " + num2);
        }
    }
}
