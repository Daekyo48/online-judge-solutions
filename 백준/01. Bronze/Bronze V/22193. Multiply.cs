using System.Numerics;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        BigInteger a = BigInteger.Parse(Console.ReadLine()!);
        BigInteger b = BigInteger.Parse(Console.ReadLine()!);

        Console.WriteLine(a * b);
    }
}