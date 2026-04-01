class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        HashSet<string> nicknames = new();
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            string log = Console.ReadLine()!;

            if (log == "ENTER")
            {
                nicknames.Clear();
                continue;
            }

            if (nicknames.Add(log))
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}