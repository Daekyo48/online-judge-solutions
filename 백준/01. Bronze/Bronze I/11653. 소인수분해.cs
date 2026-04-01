class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 2; i * i <= n; i++)
        {
            while (n % i == 0)
            {
                n /= i;
                Console.WriteLine(i);
            }
        }

        if (n > 1)
        {
            Console.WriteLine(n);
        }
    }
}