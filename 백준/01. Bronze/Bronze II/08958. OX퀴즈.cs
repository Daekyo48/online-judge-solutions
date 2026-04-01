class Program
{
    static void Main()
    {
        int testCount = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < testCount; i++)
        {
            int streak = 0;
            int score = 0;

            foreach (char result in Console.ReadLine()!)
            {
                if (result == 'O')
                {
                    score += ++streak;
                }
                else
                {
                    streak = 0;
                }
            }

            Console.WriteLine(score);
        }
    }
}