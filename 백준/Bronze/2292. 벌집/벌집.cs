using System;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            int roomNum = Int32.Parse(Console.ReadLine());
            int result = 1;
            int count = 1;
            //방의 거리가 6제곱 단위로 늘어남
            // 1 < 2칸 <= 7 < 3칸 <= 19 < 4칸 <= 37 < 5칸 <= 61 < 6칸 <= 91

            while(roomNum > result)
            {
                result = result + 6 * count;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
