class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int[] table = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        for (int i = 1; i < n; i++)
        {
            int[] costs = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            costs[0] += Math.Min(table[1], table[2]);
            costs[1] += Math.Min(table[0], table[2]);
            costs[2] += Math.Min(table[0], table[1]);

            table = costs;
        }

        Console.WriteLine(Math.Min(table[0], Math.Min(table[1], table[2])));
    }
}