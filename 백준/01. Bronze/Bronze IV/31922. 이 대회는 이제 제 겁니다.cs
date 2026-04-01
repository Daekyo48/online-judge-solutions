class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int a = int.Parse(values[0]);
        int p = int.Parse(values[1]);
        int c = int.Parse(values[2]);

        Console.WriteLine(Math.Max(a + c, p));
    }
}