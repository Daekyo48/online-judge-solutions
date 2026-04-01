class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int a = int.Parse(values[0]);
        int b = int.Parse(values[1]);

        Console.WriteLine((b + 1) / 2 - (a + 1) / 2 + 1);
    }
}