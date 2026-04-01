class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int m = int.Parse(values[1]);

        HashSet<string> s = new();
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            s.Add(Console.ReadLine()!);
        }

        for (int i = 0; i < m; i++)
        {
            if (s.Contains(Console.ReadLine()!))
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}