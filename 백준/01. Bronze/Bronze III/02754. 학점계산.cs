class Program
{
    static void Main()
    {
        string grade = Console.ReadLine()!;

        if (grade == "F")
        {
            Console.WriteLine("0.0");
            return;
        }

        double score = 4 - (grade[0] - 'A');

        if (grade[1] == '+')
        {
            score += 0.3;
        }
        else if (grade[1] == '-')
        {
            score -= 0.3;
        }

        Console.WriteLine($"{score:F1}");
    }
}