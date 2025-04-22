using System;

namespace baejoon_2178
{
    class 미로_탐색
    {        
        static int n = 0;
        static int m = 0;
        static int[] dx = { 1, -1, 0, 0 };
        static int[] dy = { 0, 0, 1, -1 };
        static bool[,] visited;
        static int[,] maze;
        static void Main(string[] args)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = inputs[0];
            m = inputs[1];
            maze = new int[n, m];
            visited = new bool[n, m];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                char[] cArr = s.ToCharArray();
                for(int j = 0; j < m; j++)
                {
                    maze[i,j] = cArr[j] - 48;
                }
            }
            Console.WriteLine(BFS(0, 0, 1));
        }

        static int BFS(int x, int y, int cnt)
        {
            Queue<(int, int, int)> q = new Queue<(int, int, int)>();            
            q.Enqueue((x, y, cnt));
            visited[x, y] = true;            
            
            while (q.Count > 0)
            {                                
                (int cx, int cy, int Count) = q.Dequeue();
                
                for (int i = 0; i < 4; i++)
                {
                    int nx = cx + dx[i];
                    int my = cy + dy[i];
                    if (nx >= 0 && nx < n && my >= 0 && my < m) //범위안에 값이 있는지
                    {
                        if (maze[nx, my] == 1)
                        {
                            if (!visited[nx,my])
                            {                                                                                                                                
                                q.Enqueue((nx, my, Count+1));
                                visited[nx, my] = true;
                                maze[nx, my] = Count + 1;
                                if (nx + my == maze.GetLength(0) + maze.GetLength(1) - 2) // 목표지점 도달
                                    return Count + 1;
                            }
                        }
                    }
                }
            }            
            return cnt;
        }
    }
}