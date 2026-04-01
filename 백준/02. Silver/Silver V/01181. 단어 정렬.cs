class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        string[] words = new string[n];

        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine()!;
        }

        Array.Sort(words, (first, second) =>
        {
            int comparison = first.Length.CompareTo(second.Length);
            if (comparison != 0) return comparison;

            return string.CompareOrdinal(first, second);
        });

        string lastWord = string.Empty;

        foreach (string word in words)
        {
            if (word == lastWord) continue;

            lastWord = word;
            Console.WriteLine(word);
        }
    }
}