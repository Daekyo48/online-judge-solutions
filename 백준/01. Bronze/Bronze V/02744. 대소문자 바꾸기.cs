class Program
{
    static void Main()
    {
        char[] word = Console.ReadLine()!.ToCharArray();

        for (int i = 0; i < word.Length; i++)
        {
            word[i] = word[i] < 'a' ? (char)(word[i] + 32) : (char)(word[i] - 32);
        }

        Console.WriteLine(word);
    }
}