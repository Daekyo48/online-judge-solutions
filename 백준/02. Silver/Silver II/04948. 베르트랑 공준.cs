class Program
{
    static void Main()
    {
        bool[] isPrime = SieveOfEratosthenes(123456 * 2);

        int[] primeCounts = new int[isPrime.Length];

        for (int i = 1; i < primeCounts.Length; i++)
        {
            primeCounts[i] = primeCounts[i - 1];

            if (isPrime[i])
            {
                primeCounts[i]++;
            }
        }

        string value;

        while ((value = Console.ReadLine()!) != "0")
        {
            int n = int.Parse(value);

            Console.WriteLine(primeCounts[n * 2] - primeCounts[n]);
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