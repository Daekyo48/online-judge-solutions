class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int count = n;

        foreach (string value in Console.ReadLine()!.Split())
        {
            int number = int.Parse(value);

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