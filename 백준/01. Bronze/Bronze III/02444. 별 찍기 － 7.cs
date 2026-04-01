class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{new string(' ', n - i)}{new string('*', i * 2 - 1)}");
        }

        for (int i = n - 1; i > 0; i--)
        {
            Console.WriteLine($"{new string(' ', n - i)}{new string('*', i * 2 - 1)}");
        }
    }
}