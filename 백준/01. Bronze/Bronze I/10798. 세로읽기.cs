class Program
{
    static void Main()
    {
        string[] words = new string[5];

        for (int i = 0; i < 5; i++)
        {
            words[i] = Console.ReadLine()!;
        }

        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i < words[j].Length)
                {
                    Console.Write(words[j][i]);
                }
            }
        }
    }
}