class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int x = int.Parse(values[0]);
        int y = int.Parse(values[1]);
        int w = int.Parse(values[2]);
        int h = int.Parse(values[3]);

        Console.WriteLine(Math.Min(Math.Min(x, w - x), Math.Min(y, h - y)));
    }
}