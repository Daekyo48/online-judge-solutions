class Program
{
    static void Main()
    {
        string s = Console.ReadLine()!;

        int[] positions = new int[26];

        Array.Fill(positions, -1);

        for (int i = 0; i < s.Length; i++)
        {
            if (positions[s[i] - 'a'] == -1)
            {
                positions[s[i] - 'a'] = i;
            }
        }

        Console.WriteLine(string.Join(' ', positions));
    }
}