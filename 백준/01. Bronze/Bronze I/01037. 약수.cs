class Program
{
    static void Main()
    {
        Console.ReadLine();

        int minFactor = int.MaxValue;
        int maxFactor = 0;

        foreach (string input in Console.ReadLine()!.Split())
        {
            int factor = int.Parse(input);

            minFactor = Math.Min(factor, minFactor);
            maxFactor = Math.Max(factor, maxFactor);
        }

        Console.WriteLine(minFactor * maxFactor);
    }
}