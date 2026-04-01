class Program
{
    static void Main()
    {
        int stepCount = int.Parse(Console.ReadLine()!);

        int[] table = new int[3];

        for (int i = 0; i < stepCount; i++)
        {
            int score = int.Parse(Console.ReadLine()!);

            (table[0], table[1], table[2]) = (
                Math.Max(table[1], table[2]),
                score + table[0],
                score + table[1]
            );
        }

        Console.WriteLine(Math.Max(table[1], table[2]));
    }
}