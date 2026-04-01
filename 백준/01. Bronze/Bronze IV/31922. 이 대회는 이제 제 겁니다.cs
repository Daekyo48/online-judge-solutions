class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine()!.Split();
        int a = int.Parse(inputs[0]);
        int p = int.Parse(inputs[1]);
        int c = int.Parse(inputs[2]);

        Console.WriteLine(Math.Max(a + c, p));
    }
}