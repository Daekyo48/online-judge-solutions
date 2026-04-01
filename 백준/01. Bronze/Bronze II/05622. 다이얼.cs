class Program
{
    static void Main()
    {
        string word = Console.ReadLine()!;

        int[] dialTimes = {
            3, 3, 3,
            4, 4, 4,
            5, 5, 5,
            6, 6, 6,
            7, 7, 7,
            8, 8, 8, 8,
            9, 9, 9,
            10, 10, 10, 10
        };

        int totalTime = 0;

        foreach (char character in word)
        {
            totalTime += dialTimes[character - 'A'];
        }

        Console.WriteLine(totalTime);
    }
}