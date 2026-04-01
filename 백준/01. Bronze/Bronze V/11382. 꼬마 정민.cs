class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine()!.Split();
        long a = long.Parse(numbers[0]);
        long b = long.Parse(numbers[1]);
        long c = long.Parse(numbers[2]);

        Console.WriteLine(a + b + c);
    }
}