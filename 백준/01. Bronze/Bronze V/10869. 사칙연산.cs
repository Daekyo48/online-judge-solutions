class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine()!.Split();
        int a = int.Parse(numbers[0]);
        int b = int.Parse(numbers[1]);

        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);
    }
}