class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine()!);

        string[] values = Console.ReadLine()!.Split();
        int w = int.Parse(values[0]);
        int v = int.Parse(values[1]);

        Console.WriteLine(a <= w / v ? 1 : 0);
    }
}