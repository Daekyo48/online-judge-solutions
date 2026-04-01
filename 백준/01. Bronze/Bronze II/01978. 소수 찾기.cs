class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int count = n;

        foreach (string input in Console.ReadLine()!.Split())
        {
            int number = int.Parse(input);

            if (number == 1)
            {
                count--;
                continue;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    count--;
                    break;
                }
            }
        }

        Console.WriteLine(count);
    }
}