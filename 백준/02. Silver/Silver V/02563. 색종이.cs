class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()!);

        int[,] canvas = new int[100, 100];
        int count = 0;

        for (int i = 0; i < number; i++)
        {
            string[] position = Console.ReadLine()!.Split();
            int left = int.Parse(position[0]);
            int bottom = int.Parse(position[1]);

            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    if (canvas[bottom + j, left + k] == 0)
                    {
                        canvas[bottom + j, left + k] = 1;
                        count++;
                    }
                }
            }
        }

        Console.WriteLine(count);
    }
}