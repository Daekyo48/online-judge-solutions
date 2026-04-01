class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int m = int.Parse(values[1]);

        int[] baskets = new int[n];

        for (int i = 0; i < n; i++)
        {
            baskets[i] = i + 1;
        }

        for (int i = 0; i < m; i++)
        {
            string[] ways = Console.ReadLine()!.Split();
            int begin = int.Parse(ways[0]) - 1;
            int end = int.Parse(ways[1]) - 1;
            
            Array.Reverse(baskets, begin, end - begin + 1);
        }

        Console.WriteLine(string.Join(' ', baskets));
    }
}