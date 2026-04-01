class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int[,] s = new int[n, n];
        bool[] visited = new bool[n];
        int minDifference = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            string[] numbers = Console.ReadLine()!.Split();

            for (int j = 0; j < n; j++)
            {
                s[i, j] = int.Parse(numbers[j]);
            }
        }

        visited[0] = true;

        DepthFirstSearch(1, 1);

        Console.WriteLine(minDifference);

        void DepthFirstSearch(int depth, int begin)
        {
            if (depth == n / 2)
            {
                int startTeamStat = 0;
                int linkTeamStat = 0;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (visited[i] && visited[j])
                        {
                            startTeamStat += s[i, j] + s[j, i];
                        }
                        else if (!visited[i] && !visited[j])
                        {
                            linkTeamStat += s[i, j] + s[j, i];
                        }
                    }
                }

                minDifference = Math.Min(Math.Abs(startTeamStat - linkTeamStat), minDifference);
                return;
            }

            for (int i = begin; i < n; i++)
            {
                visited[i] = true;

                DepthFirstSearch(depth + 1, i + 1);

                visited[i] = false;
            }
        }
    }
}