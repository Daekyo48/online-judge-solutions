class Program
{
    static void Main()
    {
        Console.ReadLine();

        int streak = 0;
        int totalScore = 0;

        foreach (string value in Console.ReadLine()!.Split())
        {
            if (value == "1")
            {
                totalScore += ++streak;
            }
            else
            {
                streak = 0;
            }
        }

        Console.WriteLine(totalScore);
    }
}