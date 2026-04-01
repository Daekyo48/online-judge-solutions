class Program
{
    static void Main()
    {
        int x = 0;
        int y = 0;

        for (int i = 0; i < 3; i++)
        {
            string[] point = Console.ReadLine()!.Split();

            x ^= int.Parse(point[0]);
            y ^= int.Parse(point[1]);
        }

        Console.WriteLine($"{x} {y}");
    }
}