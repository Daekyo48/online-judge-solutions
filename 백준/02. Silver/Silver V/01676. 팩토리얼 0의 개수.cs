class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int count = 0;

        for (int i = 5; i <= n; i *= 5)
        {
            count += n / i;
        }

        Console.WriteLine(count);
    }
}