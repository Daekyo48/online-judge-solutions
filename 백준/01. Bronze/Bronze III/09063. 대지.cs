class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int minX = int.MaxValue;
        int maxX = int.MinValue;
        int minY = int.MaxValue;
        int maxY = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            string[] position = Console.ReadLine()!.Split();
            int x = int.Parse(position[0]);
            int y = int.Parse(position[1]);

            minX = Math.Min(x, minX);
            maxX = Math.Max(x, maxX);
            minY = Math.Min(y, minY);
            maxY = Math.Max(y, maxY);
        }

        Console.WriteLine((maxX - minX) * (maxY - minY));
    }
}