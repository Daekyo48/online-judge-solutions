class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int[] table = new int[n + 1];

        for (int i = 2; i <= n; i++)
        {
            table[i] = table[i - 1] + 1;

            if (i % 2 == 0)
            {
                table[i] = Math.Min(table[i], table[i / 2] + 1);
            }

            if (i % 3 == 0)
            {
                table[i] = Math.Min(table[i], table[i / 3] + 1);
            }
        }

        Console.WriteLine(table[n]);
    }
}