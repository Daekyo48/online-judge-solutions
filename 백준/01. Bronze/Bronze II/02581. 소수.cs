class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine()!);
        int n = int.Parse(Console.ReadLine()!);

        int sum = 0;
        int min = int.MaxValue;

        for (int i = m; i <= n; i++)
        {
            if (i == 1) continue;

            bool isPrime = true;

            for (int j = 2; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                sum += i;
                min = i < min ? i : min;
            }
        }

        if (sum == 0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(sum);
            Console.WriteLine(min); 
        }
    }
}