class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine()!.Split()[1]);

        foreach (string value in Console.ReadLine()!.Split())
        {
            int number = int.Parse(value);

            if (number < x)
            {
                Console.Write($"{number} ");
            }
        }
    }
}