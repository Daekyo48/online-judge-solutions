class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        long[] table = PadovanSequence(100);

        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine(table[n]);
        }
    }

    static long[] PadovanSequence(int n)
    {
        long[] sequence = new long[n + 1];

        sequence[1] = 1;
        sequence[2] = 1;

        for (int i = 3; i <= n; i++)
        {
            sequence[i] = sequence[i - 2] + sequence[i - 3];
        }

        return sequence;
    }
}