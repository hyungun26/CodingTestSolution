namespace baekjoon_25305
{
    class  커트라인
    {
        static void Main()
        {
            List<int> ints = new List<int>();
            string s = Console.ReadLine();
            char[] cArr = s.ToCharArray();
            foreach (char c in cArr)
            {
                ints.Add(c-48);
            }            
            ints = ints.OrderByDescending(i => i).ToList();            
            foreach(var i in ints)
            {
                Console.Write(i);
            }
        }
    }
}
