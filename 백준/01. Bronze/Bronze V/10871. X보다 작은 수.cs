class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine()!.Split()[1]);

        foreach (string input in Console.ReadLine()!.Split())
        {
            int number = int.Parse(input);

            if (number < x)
            {
                Console.Write($"{number} ");
            }
        }
    }
}