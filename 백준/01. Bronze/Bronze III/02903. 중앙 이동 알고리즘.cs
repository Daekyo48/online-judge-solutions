class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine(((1 << n) + 1) * ((1 << n) + 1));
    }
}