using System.Numerics;

class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine()!.Split();
        BigInteger a = BigInteger.Parse(numbers[0]);
        BigInteger b = BigInteger.Parse(numbers[1]);

        Console.WriteLine(a * b);
    }
}