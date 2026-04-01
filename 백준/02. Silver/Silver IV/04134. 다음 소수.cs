class Program
{
    static void Main()
    {
        int testCount = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < testCount; i++)
        {
            long n = long.Parse(Console.ReadLine()!);

            bool isPrime = false;

            if (n <= 2)
            {
                Console.WriteLine(2);
                continue;
            }

            if (n % 2 == 0)
            {
                n++;
            }

            while (!isPrime)
            {
                isPrime = true;

                for (long j = 3; j * j <= n; j += 2)
                {
                    if (n % j == 0)
                    {
                        isPrime = false;
                        n += 2;
                        break;
                    }
                }
            }

            Console.WriteLine(n);
        }
    }
}