class Program
{
    static void Main()
    {
        int[] fractionA = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        int[] fractionB = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        int numerator = fractionA[0] * fractionB[1] + fractionA[1] * fractionB[0];
        int denominator = fractionA[1] * fractionB[1];

        int divisor = GreatestCommonDivisor(numerator, denominator);

        Console.WriteLine($"{numerator / divisor} {denominator / divisor}");
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