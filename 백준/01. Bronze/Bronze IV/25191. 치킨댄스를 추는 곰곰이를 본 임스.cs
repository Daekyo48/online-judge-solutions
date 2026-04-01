class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        string[] values = Console.ReadLine()!.Split();
        int a = int.Parse(values[0]) / 2;
        int b = int.Parse(values[1]);

        Console.WriteLine(Math.Min(n, a + b));
    }
}