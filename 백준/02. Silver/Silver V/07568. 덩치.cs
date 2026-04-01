class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        (int x, int y)[] sizes = new (int, int)[n];
        int[] ranks = new int[n];

        for (int i = 0; i < n; i++)
        {
            string[] size = Console.ReadLine()!.Split();

            sizes[i] = (int.Parse(size[0]), int.Parse(size[1]));
        }

        for (int i = 0; i < n; i++)
        {
            int rank = 1;

            for (int j = 0; j < n; j++)
            {
                if (i == j) continue;

                if (sizes[i].x < sizes[j].x && sizes[i].y < sizes[j].y)
                {
                    rank++;
                }
            }

            ranks[i] = rank;
        }

        Console.WriteLine(string.Join(' ', ranks));
    }
}