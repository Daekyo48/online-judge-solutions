class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine()!);

        string[] inputs = Console.ReadLine()!.Split();
        int w = int.Parse(inputs[0]);
        int v = int.Parse(inputs[1]);

        Console.WriteLine(a <= w / v ? 1 : 0);
    }
}