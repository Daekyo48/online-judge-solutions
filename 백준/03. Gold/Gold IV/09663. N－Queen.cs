class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        bool[][] visited =
        {
            new bool[n],
            new bool[n * 2 - 1],
            new bool[n * 2 - 1]
        };

        int count = 0;

        DepthFirstSearch(0);

        Console.WriteLine(count);

        void DepthFirstSearch(int depth)
        {
            if (depth == n)
            {
                count++;
                return;
            }

            for (int i = 0; i < n; i++)
            {
                int mainDiagonalIndex = depth - i + n - 1;
                int antiDiagonalIndex = depth + i;

                if (visited[0][i]) continue;
                if (visited[1][mainDiagonalIndex]) continue;
                if (visited[2][antiDiagonalIndex]) continue;

                visited[0][i] = true;
                visited[1][mainDiagonalIndex] = true;
                visited[2][antiDiagonalIndex] = true;

                DepthFirstSearch(depth + 1);

                visited[0][i] = false;
                visited[1][mainDiagonalIndex] = false;
                visited[2][antiDiagonalIndex] = false;
            }
        }
    }
}