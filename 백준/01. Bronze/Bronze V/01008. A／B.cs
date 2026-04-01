class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine()!.Split();
        double a = int.Parse(numbers[0]);
        double b = int.Parse(numbers[1]);

        Console.WriteLine(a / b);
    }
}