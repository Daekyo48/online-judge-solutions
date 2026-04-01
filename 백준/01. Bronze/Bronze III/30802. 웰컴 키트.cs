class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int[] shirtCounts = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        string[] values = Console.ReadLine()!.Split();
        int t = int.Parse(values[0]);
        int p = int.Parse(values[1]);

        int shirtBundles = 0;

        for (int i = 0; i < shirtCounts.Length; i++)
        {
            if (shirtCounts[i] == 0) continue;

            shirtBundles += (shirtCounts[i] - 1) / t + 1;
        }

        Console.WriteLine(shirtBundles);
        Console.WriteLine($"{n / p} {n % p}");
    }
}