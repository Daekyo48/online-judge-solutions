class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine()!.Split();
        string a = numbers[0];
        string b = numbers[1];

        int numberA = (a[2] - '0') * 100 + (a[1] - '0') * 10 + (a[0] - '0');
        int numberB = (b[2] - '0') * 100 + (b[1] - '0') * 10 + (b[0] - '0');

        Console.WriteLine(Math.Max(numberA, numberB));
    }
}