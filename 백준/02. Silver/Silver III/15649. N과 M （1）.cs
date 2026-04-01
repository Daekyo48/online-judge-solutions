class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        string[] numbers = reader.ReadLine()!.Split();
        int n = int.Parse(numbers[0]);
        int m = int.Parse(numbers[1]);

        int[] buffer = new int[m];
        bool[] visited = new bool[n];

        DepthFirstSearch(0);

        writer.Close();

        void DepthFirstSearch(int depth)
        {
            if (depth == m)
            {
                writer.WriteLine(string.Join(' ', buffer));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (visited[i]) continue;

                buffer[depth] = i + 1;
                visited[i] = true;

                DepthFirstSearch(depth + 1);

                visited[i] = false;
            }
        }
    }
}