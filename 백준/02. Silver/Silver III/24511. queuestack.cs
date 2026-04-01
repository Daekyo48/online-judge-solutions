class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        string[] a = Console.ReadLine()!.Split();
        string[] b = Console.ReadLine()!.Split();

        int m = int.Parse(Console.ReadLine()!);
        string[] c = Console.ReadLine()!.Split();

        List<string> results = new();

        for (int i = 1; i <= n && results.Count < m; i++)
        {
            if (a[^i] == "0")
            {
                results.Add(b[^i]);
            }
        }

        for (int i = 0; i < m && results.Count < m; i++)
        {
            results.Add(c[i]);
        }

        Console.WriteLine(string.Join(' ', results));
    }
}