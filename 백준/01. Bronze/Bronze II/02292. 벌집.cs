class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int distance = 1;

        while (1 + 3 * distance * (distance - 1) < n)
        {
            distance++;
        }

        Console.WriteLine(distance);
    }
}