class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        double totalScore = 0;
        double maxScore = 0;

        foreach (string input in Console.ReadLine()!.Split())
        {
            int score = int.Parse(input);

            totalScore += score;
            maxScore = Math.Max(score, maxScore);
        }

        Console.WriteLine(totalScore * 100 / (maxScore * n));
    }
}