using System;

namespace baekjoon
{
    class baekjoon
    {
        static void Main()
        {
            int roomNum = Int32.Parse(Console.ReadLine());
            int room = 1;
            int rooms = 1;
            bool roomC = false;
            bool roomsC = false;

            bool zig = false;
            for (int i = 1; i < roomNum; i++) 
            {
                if(room == 1)
                {
                    roomC = true;
                }
                if(rooms == 1)
                {
                    roomsC = true;
                }

                if (roomC && roomsC)
                {
                    if (room == 1)
                    {
                        rooms += 1;
                    }
                    else
                        room += 1;
                    zig = !zig;
                    roomC = false;
                    roomsC = false;
                    continue;
                }
                //zig상태에 따라 업 다운 변경
                if (zig)
                {
                    room += 1;
                    rooms -= 1;
                }
                else
                {
                    room -= 1;
                    rooms += 1;
                }
            }
            Console.WriteLine(room + "/" + rooms);
        }
    }
}
