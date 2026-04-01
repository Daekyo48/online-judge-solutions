class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int[] table = { int.Parse(Console.ReadLine()!) };

        for (int i = 1; i < n; i++)
        {
            int[] row = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            row[0] += table[0];
            row[i] += table[i - 1];

            for (int j = 1; j < i; j++)
            {
                row[j] += Math.Max(table[j - 1], table[j]);
            }

            table = row;
        }

        int bestSum = 0;

        foreach (int element in table)
        {
            bestSum = Math.Max(element, bestSum);
        }

        Console.WriteLine(bestSum);
    }
}