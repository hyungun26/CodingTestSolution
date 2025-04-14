namespace baejoon_1926
{
    class 그림
    {
        static int n = 0;
        static int m = 0;
        static int[,] graph;
        static bool[,] visited;
        static int[] dx = { 1, -1, 0, 0 };
        static int[] dy = { 0, 0, 1, -1 };
        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = inputs[0];
            m = inputs[1];
            graph = new int[n, m];
            visited = new bool[n, m];
            for(int i = 0; i < n; i++)
            {
                int[] inputGraph = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    graph[i,j] = inputGraph[j];
                }
            }

            int count = 0;
            int maxSize = 0;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(graph[i,j] == 1 && !visited[i,j])
                    {
                        count++;
                        int size = BFS(i, j);
                        maxSize = Math.Max(maxSize, size);
                    }
                }
            }

            Console.WriteLine(count);
            Console.WriteLine(maxSize);
        }

        static int BFS(int x, int y)
        {
            Queue<(int, int)> q = new Queue<(int, int)> ();
            q.Enqueue((x, y));
            int size = 1;
            visited[x, y] = true;

            while (q.Count > 0)
            {
                (int cx, int cy) = q.Dequeue ();
                for(int i = 0; i < 4; i++)
                {
                    int nx = cx + dx[i];
                    int my = cy + dy[i];
                    if (nx >= 0 && nx < n && my >= 0 && my < m && !visited[nx, my] && graph[nx, my] == 1)
                    {
                        size++;
                        visited[nx, my] = true;
                        q.Enqueue((nx, my));
                    }
                }
            }

            return size;
        }
    }
}