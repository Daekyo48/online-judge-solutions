class Program
{
    static void Main()
    {
        Dictionary<string, double> gradeToScore = new()
        {
            { "A+", 4.5 },
            { "A0", 4.0 },
            { "B+", 3.5 },
            { "B0", 3.0 },
            { "C+", 2.5 },
            { "C0", 2.0 },
            { "D+", 1.5 },
            { "D0", 1.0 },
            { "F", 0.0 }
        };

        double total = 0;
        double totalCredit = 0;

        for (int i = 0; i < 20; i++)
        {
            string[] values = Console.ReadLine()!.Split();
            double credit = double.Parse(values[1]);
            string grade = values[2];

            if (grade != "P")
            {
                total += credit * gradeToScore[grade];
                totalCredit += credit;
            }
        }

        Console.WriteLine(total / totalCredit);
    }
}