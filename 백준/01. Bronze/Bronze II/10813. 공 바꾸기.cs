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
            int first = int.Parse(ways[0]) - 1;
            int second = int.Parse(ways[1]) - 1;

            (baskets[first], baskets[second]) = (baskets[second], baskets[first]);
        }

        Console.WriteLine(string.Join(' ', baskets));
    }
}