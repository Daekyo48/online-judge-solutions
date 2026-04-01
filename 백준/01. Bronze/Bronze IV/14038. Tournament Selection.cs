class Program
{
    static void Main()
    {
        int winCount = 0;

        for (int i = 0; i < 6; i++)
        {
            if (Console.ReadLine() == "W")
            {
                winCount++;
            }
        }

        if (winCount >= 5)
        {
            Console.WriteLine(1);
        }
        else if (winCount >= 3)
        {
            Console.WriteLine(2);
        }
        else if (winCount >= 1)
        {
            Console.WriteLine(3);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }
}