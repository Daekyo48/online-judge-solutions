class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int m = int.Parse(values[1]);

        HashSet<string> unheardNames = new();
        List<string> unheardUnseenNames = new();

        for (int i = 0; i < n; i++)
        {
            unheardNames.Add(Console.ReadLine()!);
        }

        for (int i = 0; i < m; i++)
        {
            string name = Console.ReadLine()!;

            if (unheardNames.Contains(name))
            {
                unheardUnseenNames.Add(name);
            }
        }

        unheardUnseenNames.Sort();

        Console.WriteLine(unheardUnseenNames.Count);

        foreach (string name in unheardUnseenNames)
        {
            Console.WriteLine(name);
        }
    }
}