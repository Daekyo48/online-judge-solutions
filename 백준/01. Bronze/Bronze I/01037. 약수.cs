class Program
{
    static void Main()
    {
        Console.ReadLine();

        int minFactor = int.MaxValue;
        int maxFactor = 0;

        foreach (string value in Console.ReadLine()!.Split())
        {
            int factor = int.Parse(value);

            minFactor = Math.Min(factor, minFactor);
            maxFactor = Math.Max(factor, maxFactor);
        }

        Console.WriteLine(minFactor * maxFactor);
    }
}