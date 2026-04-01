class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int a = int.Parse(values[0]);
        int b = int.Parse(values[1]);
        int c = int.Parse(values[2]);
        int d = int.Parse(values[3]);
        int e = int.Parse(values[4]);
        int f = int.Parse(values[5]);

        int x = (c * e - b * f) / (a * e - b * d);
        int y = (c * d - a * f) / (b * d - a * e);

        Console.WriteLine($"{x} {y}");
    }
}