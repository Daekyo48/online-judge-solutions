class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine()!);

        if (n >= short.MinValue && n <= short.MaxValue)
        {
            Console.WriteLine("short");
        }
        else if (n >= int.MinValue && n <= int.MaxValue)
        {
            Console.WriteLine("int");
        }
        else
        {
            Console.WriteLine("long long");
        }
    }
}