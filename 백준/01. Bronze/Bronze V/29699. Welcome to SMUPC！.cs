class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine("WelcomeToSMUPC"[(n - 1) % 14]);
    }
}