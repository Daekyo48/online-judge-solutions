class Program
{
    static void Main()
    {
        string s = Console.ReadLine()!;

        HashSet<string> substrings = new();

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 1; j <= s.Length - i; j++)
            {
                substrings.Add(s.Substring(i, j));
            }
        }

        Console.WriteLine(substrings.Count);
    }
}