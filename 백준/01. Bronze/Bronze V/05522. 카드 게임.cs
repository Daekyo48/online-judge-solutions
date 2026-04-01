class Program
{
    static void Main()
    {
        int totalScore = 0;

        for (int i = 0; i < 5; i++)
        {
            int a = int.Parse(Console.ReadLine()!);

            totalScore += a;
        }

        Console.WriteLine(totalScore);
    }
}