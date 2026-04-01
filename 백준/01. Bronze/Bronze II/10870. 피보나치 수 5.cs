class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine(Fibonacci(n));
    }

    static int Fibonacci(int n)
    {
        if (n < 2) return n;

        int previous = 0;
        int current = 1;

        for (int i = 2; i <= n; i++)
        {
            (previous, current) = (current, previous + current);
        }

        return current;
    }
}