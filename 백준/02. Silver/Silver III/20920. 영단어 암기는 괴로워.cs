class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        string[] values = reader.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int m = int.Parse(values[1]);

        Dictionary<string, int> wordToCount = new();

        for (int i = 0; i < n; i++)
        {
            string word = reader.ReadLine()!;

            if (word.Length >= m)
            {
                wordToCount[word] = wordToCount.GetValueOrDefault(word) + 1;
            }
        }

        List<KeyValuePair<string, int>> words = wordToCount.ToList();

        words.Sort((first, second) =>
        {
            int comparison = second.Value.CompareTo(first.Value);
            if (comparison != 0) return comparison;

            comparison = second.Key.Length.CompareTo(first.Key.Length);
            if (comparison != 0) return comparison;

            return string.CompareOrdinal(first.Key, second.Key);
        });

        foreach (KeyValuePair<string, int> word in words)
        {
            writer.WriteLine(word.Key);
        }

        writer.Close();
    }
}