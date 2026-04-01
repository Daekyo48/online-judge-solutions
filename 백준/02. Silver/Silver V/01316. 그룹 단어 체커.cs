class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int count = 0;

        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine()!;

            bool[] seen = new bool[26];

            for (int j = 1; j < word.Length; j++)
            {
                seen[word[j - 1] - 'a'] = true;

                if (word[j] != word[j - 1] && seen[word[j] - 'a'])
                {
                    count++;
                    break;
                }
            }
        }

        Console.WriteLine(n - count);
    }
}