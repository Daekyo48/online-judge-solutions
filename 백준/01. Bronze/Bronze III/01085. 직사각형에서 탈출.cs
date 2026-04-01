class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine()!.Split();
        int x = int.Parse(inputs[0]);
        int y = int.Parse(inputs[1]);
        int w = int.Parse(inputs[2]);
        int h = int.Parse(inputs[3]);

        Console.WriteLine(Math.Min(Math.Min(x, w - x), Math.Min(y, h - y)));
    }
}