class Program
{
    static void Main()
    {
        Console.ReadLine();

        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (string value in Console.ReadLine()!.Split())
        {
            int number = int.Parse(value);

            min = Math.Min(number, min);
            max = Math.Max(number, max);
        }

        Console.WriteLine($"{min} {max}");
    }
}