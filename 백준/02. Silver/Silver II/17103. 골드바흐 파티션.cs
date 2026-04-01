class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        List<int> primes = new();

        bool[] isPrime = SieveOfEratosthenes(1000000);

        for (int i = 2; i < isPrime.Length; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }

        for (int i = 0; i < t; i++)
        {
            int number = int.Parse(Console.ReadLine()!);

            int count = 0;

            foreach (int prime in primes)
            {
                if (prime > number / 2) break;

                if (isPrime[number - prime])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
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