class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        string[] drinks = Console.ReadLine()!.Split();
        int a = int.Parse(drinks[0]) / 2;
        int b = int.Parse(drinks[1]);

        Console.WriteLine(Math.Min(n, a + b));
    }
}