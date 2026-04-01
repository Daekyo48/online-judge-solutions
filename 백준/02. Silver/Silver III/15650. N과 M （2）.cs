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

        DepthFirstSearch(0);

        writer.Close();

        void DepthFirstSearch(int depth)
        {
            if (depth == m)
            {
                writer.WriteLine(string.Join(' ', buffer));
                return;
            }

            int begin = depth == 0 ? 1 : buffer[depth - 1] + 1;

            for (int i = begin; i <= n; i++)
            {
                buffer[depth] = i;

                DepthFirstSearch(depth + 1);
            }
        }
    }
}