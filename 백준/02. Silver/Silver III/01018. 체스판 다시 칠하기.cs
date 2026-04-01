class Program
{
    static void Main()
    {
        string[] sizes = Console.ReadLine()!.Split();
        int n = int.Parse(sizes[0]);
        int m = int.Parse(sizes[1]);

        char[] color = { 'W', 'B' };
        char[,] board = new char[n, m];
        int repaintCount = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            string colors = Console.ReadLine()!;

            for (int j = 0; j < m; j++)
            {
                board[i, j] = colors[j];
            }
        }

        for (int i = 0; i <= n - 8; i++)
        {
            for (int j = 0; j <= m - 8; j++)
            {
                int count = 0;

                for (int k = 0; k < 8; k++)
                {
                    for (int l = 0; l < 8; l++)
                    {
                        if (board[i + k, j + l] != color[(k + l) % 2])
                        {
                            count++;
                        }
                    }
                }

                repaintCount = Math.Min(Math.Min(count, 64 - count), repaintCount);
            }
        }

        Console.WriteLine(repaintCount);
    }
}