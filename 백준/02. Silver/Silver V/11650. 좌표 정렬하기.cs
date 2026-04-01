class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        (int x, int y)[] points = new (int, int)[n];

        for (int i = 0; i < n; i++)
        {
            string[] point = Console.ReadLine()!.Split();

            points[i] = (int.Parse(point[0]), int.Parse(point[1]));
        }

        Array.Sort(points);

        foreach ((int x, int y) in points)
        {
            Console.WriteLine($"{x} {y}");
        }
    }
}