namespace baekjoon_2920
{
    class 음계
    {
        static void Main()
        {
            int[] iArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string s = "";
            if (iArr[0] == 1)
            {
                s = string.Join("",iArr);
                if (s == "12345678")
                    Console.WriteLine("ascending");
                else
                    Console.WriteLine("mixed");
            }
            else if(iArr[0] == 8)
            {
                s = string.Join("", iArr);
                if (s == "87654321")
                    Console.WriteLine("descending");
                else
                    Console.WriteLine("mixed");
            }
            else
                Console.WriteLine("mixed");
        }
    }
}
