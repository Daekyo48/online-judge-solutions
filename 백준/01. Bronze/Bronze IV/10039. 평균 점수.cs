class Program
{
    static void Main()
    {
        int totalScore = 0;

        for (int i = 0; i < 5; i++)
        {
            int score = Math.Max(40, int.Parse(Console.ReadLine()!));

            totalScore += score;
        }

        Console.WriteLine(totalScore / 5);
    }
}