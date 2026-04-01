class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!) - 1;
        int previousLocation = int.Parse(Console.ReadLine()!);

        int totalGap = 0;
        int divisor = 0;

        for (int i = 0; i < n; i++)
        {
            int location = int.Parse(Console.ReadLine()!);
            int gap = location - previousLocation;

            divisor = i == 0 ? gap : GreatestCommonDivisor(divisor, gap);

            totalGap += gap;
            previousLocation = location;
        }

        Console.WriteLine(totalGap / divisor - n);
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