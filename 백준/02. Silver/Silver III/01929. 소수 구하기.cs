class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int m = int.Parse(values[0]);
        int n = int.Parse(values[1]);

        bool[] isPrime = SieveOfEratosthenes(n);

        for (int i = m; i <= n; i++)
        {
            if (isPrime[i])
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool[] SieveOfEratosthenes(int n)
    {
        bool[] isPrime = new bool[n + 1];

        Array.Fill(isPrime, true, 2, isPrime.Length - 2);

        for (int i = 2; i * i <= n; i++)
        {
            if (!isPrime[i]) continue;

            for (int j = i * i; j <= n; j += i)
            {
                isPrime[j] = false;
            }
        }

        return isPrime;
    }
}