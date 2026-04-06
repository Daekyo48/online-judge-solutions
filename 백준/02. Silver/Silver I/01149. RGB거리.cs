class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int[] minCosts = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        for (int i = 0; i < n - 1; i++)
        {
            int[] costs = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            costs[0] += Math.Min(minCosts[1], minCosts[2]);
            costs[1] += Math.Min(minCosts[0], minCosts[2]);
            costs[2] += Math.Min(minCosts[0], minCosts[1]);

            minCosts = costs;
        }

        Console.WriteLine(Math.Min(minCosts[0], Math.Min(minCosts[1], minCosts[2])));
    }
}