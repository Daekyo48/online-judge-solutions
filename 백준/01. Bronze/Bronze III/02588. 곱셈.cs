class Program
{
    static void Main()
    {
        int multiplicand = int.Parse(Console.ReadLine()!);
        int multiplier = int.Parse(Console.ReadLine()!);

        int ones = multiplier % 10;
        int tens = multiplier % 100 / 10;
        int hundreds = multiplier / 100;

        Console.WriteLine(multiplicand * ones);
        Console.WriteLine(multiplicand * tens);
        Console.WriteLine(multiplicand * hundreds);
        Console.WriteLine(multiplicand * multiplier);
    }
}