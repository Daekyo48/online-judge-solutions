class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine()!.Split();
        int n = int.Parse(inputs[0]);
        int m = int.Parse(inputs[1]);

        string[] baseStats = Console.ReadLine()!.Split();
        int baseSum = int.Parse(baseStats[0]) + int.Parse(baseStats[1]) + int.Parse(baseStats[2]);

        List<(int statSum, int index)> students = new();
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            string[] stats = Console.ReadLine()!.Split();
            int sum = int.Parse(stats[0]) + int.Parse(stats[1]) + int.Parse(stats[2]);

            if (sum <= baseSum)
            {
                students.Add((sum, i));
            }
        }

        students.Sort();

        Console.Write("0 ");

        for (int i = 1; i <= students.Count; i++)
        {
            if (count++ >= m - 1) return;

            Console.Write($"{students[^i].index} ");
        }
    }
}