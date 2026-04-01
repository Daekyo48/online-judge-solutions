class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine()!.Split();
        int a = int.Parse(numbers[0]);
        int b = int.Parse(numbers[1]);

        int divisor = GreatestCommonDivisor(a, b);

        Console.WriteLine(divisor);
        Console.WriteLine(a * b / divisor);
    }

    static int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            (a, b) = (b, a % b);
        }

        return a;
    }
}