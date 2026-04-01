class Program
{
    static void Main()
    {
        string[] times = Console.ReadLine()!.Split();
        int a = int.Parse(times[0]);
        int b = int.Parse(times[1]);

        int c = int.Parse(Console.ReadLine()!);

        b += c;
        a += b / 60;

        Console.WriteLine($"{a % 24} {b % 60}");
    }
}