class Program
{
    static void Main()
    {
        string word = Console.ReadLine()!.ToUpper();

        int[] counts = new int[26];

        foreach (char character in word)
        {
            counts[character - 'A']++;
        }

        int maxCount = 0;
        int maxIndex = 0;
        bool hasMultiple = false;

        for (int i = 0; i < 26; i++)
        {
            if (counts[i] > maxCount)
            {
                maxCount = counts[i];
                maxIndex = i;
                hasMultiple = false;
            }
            else if (counts[i] == maxCount)
            {
                hasMultiple = true;
            }
        }

        Console.WriteLine(hasMultiple ? '?' : (char)(maxIndex + 'A'));
    }
}