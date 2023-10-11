using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] answer = new int[2];
        Queue<string> rou = new Queue<string>();
        for(int i = 0; i < routes.GetLength(0); i++) rou.Enqueue(routes[i]);
        
        bool check = false;
        int[] dog = new int[2];
        
        for(int i = 0; i < park.GetLength(0); i++)
        {
            for(int j = 0; j < park[i].Length; j++)
            {
                if(park[i][j] == 'S')
                {
                    dog[0] = i;
                    dog[1] = j;
                    check = true;
                }
            }
            if(check) break;
        }

        Console.Write(dog[0]);
        Console.Write(dog[1]);
        Console.WriteLine();
        
        while(rou.Count != 0)
        {
            check = false;
            string s = rou.Peek();
            char c = s[0];
            int n = (int)s[2] % 48;
            
            switch(c)
            {
                case 'E' : 
                    if(dog[1] + n > park[0].Length-1)
                    {
                    }
                    else
                    {
                        //넣기전에 x장애물이 있는 검사를 한번더 해야한다.
                        for(int i = 1; i <= n; i++)
                        {
                            if(park[dog[0]][dog[1]+i] == 'X')
                            {
                                check = true;
                                break;
                            }
                        }
                        if(!check)
                        dog[1] += n;
                    }
                    rou.Dequeue();
                    break;
                case 'W' :
                    if(dog[1] - n < 0) // 공원범위를 벗어남
                    {
                    }
                    else
                    {
                        //공원범위를 벗어나지 않았다면 장애물이 있는지 검사를 해야함
                        for(int i = 1; i <= n; i ++)
                        {
                            if(park[dog[0]][dog[1] - i] == 'X')
                            {
                                check = true;
                                break;
                            }
                        }
                        if(!check)
                            dog[1] -= n;
                    }
                    rou.Dequeue();
                    break;
                case 'S' : 
                    if(dog[0] + n > park.GetLength(0)-1)
                    {
                    }
                    else
                    {
                        for(int i = 1; i <= n; i++)
                        {
                            if(park[dog[0]+i][dog[1]] == 'X')
                            {
                                check = true;
                                break;
                            }
                        }
                        if(!check)
                        dog[0] += n;
                    }
                    rou.Dequeue();
                    break;
                case 'N' : 
                    if(dog[0] - n < 0) // 공원범위를 벗어남
                    {
                    }
                    else
                    {
                        //공원범위를 벗어나지 않았다면 장애물이 있는지 검사를 해야함
                        for(int i = 1; i <= n; i ++)
                        {
                            if(park[dog[0] - i][dog[1]] == 'X')
                            {
                                check = true;
                                break;
                            }
                        }
                        if(!check)
                            dog[0] -= n;
                    }
                    rou.Dequeue();
                    break;
            }
        }
        answer[0] = dog[0];
        answer[1] = dog[1];
        return answer;
    }
}