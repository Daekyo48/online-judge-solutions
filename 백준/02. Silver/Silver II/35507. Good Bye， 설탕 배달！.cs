class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine()!);

            long[] stats = new long[3];
            bool canComplete = true;

            for (int j = 1; j <= n; j++)
            {
                string[] inputs = Console.ReadLine()!.Split();
                long a = long.Parse(inputs[0]);
                long b = long.Parse(inputs[1]);
                long c = long.Parse(inputs[2]);
                long p = long.Parse(inputs[3]);

                (stats[0], stats[1], stats[2]) = (
                    Math.Max(a, stats[0]),
                    Math.Max(b, stats[1]),
                    Math.Max(c, stats[2])
                );

                if (stats[0] + stats[1] + stats[2] + j > p)
                {
                    canComplete = false;

                    for (int k = j + 1; k <= n; k++)
                    {
                        Console.ReadLine();
                    }

                    break;
                }
            }

            Console.WriteLine(canComplete ? "YES" : "NO");
        }
    }
}