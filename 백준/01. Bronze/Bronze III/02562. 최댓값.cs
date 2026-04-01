class Program
{
    static void Main()
    {
        int max = 0;
        int index = 0;

        for (int i = 0; i < 9; i++)
        {
            int number = int.Parse(Console.ReadLine()!);

            if (number > max)
            {
                max = number;
                index = i;
            }
        }

        Console.WriteLine(max);
        Console.WriteLine(index + 1);
    }
}