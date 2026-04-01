class Program
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"{new string('1', k)}{new string('0', k - 1)}");
    }
}