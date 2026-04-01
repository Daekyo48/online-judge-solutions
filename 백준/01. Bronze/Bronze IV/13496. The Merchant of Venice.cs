class Program
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= k; i++)
        {
            string[] values = Console.ReadLine()!.Split();
            int n = int.Parse(values[0]);
            int s = int.Parse(values[1]);
            int d = int.Parse(values[2]);

            int totalDucats = 0;

            for (int j = 0; j < n; j++)
            {
                string[] ship = Console.ReadLine()!.Split();
                int distance = int.Parse(ship[0]);
                int volume = int.Parse(ship[1]);

                if (distance <= s * d)
                {
                    totalDucats += volume;
                }
            }

            Console.WriteLine($"Data Set {i}:");
            Console.WriteLine(totalDucats);
            Console.WriteLine();
        }
    }
}