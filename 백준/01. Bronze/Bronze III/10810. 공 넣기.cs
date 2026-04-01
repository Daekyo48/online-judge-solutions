class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int m = int.Parse(values[1]);

        int[] baskets = new int[n];

        for (int i = 0; i < m; i++)
        {
            string[] ways = Console.ReadLine()!.Split();
            int begin = int.Parse(ways[0]) - 1;
            int end = int.Parse(ways[1]) - 1;
            int number = int.Parse(ways[2]);

            Array.Fill(baskets, number, begin, end - begin + 1);
        }

        Console.WriteLine(string.Join(' ', baskets));
    }
}