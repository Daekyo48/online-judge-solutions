class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        (int y, int x)[] points = new (int, int)[n];

        for (int i = 0; i < n; i++)
        {
            string[] point = Console.ReadLine()!.Split();

            points[i] = (int.Parse(point[1]), int.Parse(point[0]));
        }

        Array.Sort(points);

        foreach ((int y, int x) in points)
        {
            Console.WriteLine($"{x} {y}");
        }
    }
}