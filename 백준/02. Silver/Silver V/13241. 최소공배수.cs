class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine()!.Split();
        long a = long.Parse(numbers[0]);
        long b = long.Parse(numbers[1]);

        Console.WriteLine(a * b / GreatestCommonDivisor(a, b));
    }

    static long GreatestCommonDivisor(long a, long b)
    {
        while (b != 0)
        {
            (a, b) = (b, a % b);
        }

        return a;
    }
}