class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int m = int.Parse(values[1]);

        string[] baseStat = Console.ReadLine()!.Split();
        int baseSum = int.Parse(baseStat[0]) + int.Parse(baseStat[1]) + int.Parse(baseStat[2]);

        List<(int statSum, int index)> students = new();
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            string[] stat = Console.ReadLine()!.Split();
            int sum = int.Parse(stat[0]) + int.Parse(stat[1]) + int.Parse(stat[2]);

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