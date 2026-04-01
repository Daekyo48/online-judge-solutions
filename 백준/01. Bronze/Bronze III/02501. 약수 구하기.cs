class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int k = int.Parse(values[1]);

        List<int> factors = new();

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                factors.Add(i);
            }
        }

        Console.WriteLine(factors.Count < k ? 0 : factors[k - 1]);
    }
}