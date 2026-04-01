class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }

        int[] difficulties = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int difficulty = int.Parse(Console.ReadLine()!);

            difficulties[i] = difficulty;
            sum += difficulty;
        }

        Array.Sort(difficulties);

        int trimCount = (int)Math.Round(n * 0.15, MidpointRounding.AwayFromZero);

        for (int i = 0; i < trimCount; i++)
        {
            sum -= difficulties[i];
            sum -= difficulties[^(i + 1)];
        }

        double trimmedMean = (double)sum / (n - trimCount * 2);

        Console.WriteLine(Math.Round(trimmedMean, MidpointRounding.AwayFromZero));
    }
}