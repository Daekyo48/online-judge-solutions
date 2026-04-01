class Program
{
    static void Main()
    {
        int max = 0;
        int rowIndex = 0;
        int columnIndex = 0;

        for (int i = 0; i < 9; i++)
        {
            string[] numbers = Console.ReadLine()!.Split();

            for (int j = 0; j < 9; j++)
            {
                int number = int.Parse(numbers[j]);

                if (number > max)
                {
                    max = number;
                    rowIndex = i;
                    columnIndex = j;
                }
            }
        }

        Console.WriteLine(max);
        Console.WriteLine($"{rowIndex + 1} {columnIndex + 1}");
    }
}