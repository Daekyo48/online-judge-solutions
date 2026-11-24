class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int[] tableA = new int[n];
        int[] tableB = new int[n];

        for (int i = 0; i < n; i++)
        {
            tableA[i] = 1;
            tableB[^(i + 1)] = 1;

            for (int j = 0; j < i; j++)
            {
                if (a[i] > a[j])
                {
                    tableA[i] = Math.Max(tableA[i], tableA[j] + 1);
                }

                if (a[^(i + 1)] > a[^(j + 1)])
                {
                    tableB[^(i + 1)] = Math.Max(tableB[^(i + 1)], tableB[^(j + 1)] + 1);
                }
            }
        }

        int maxLength = 0;

        for (int i = 0; i < n; i++)
        {
            maxLength = Math.Max(tableA[i] + tableB[i] - 1, maxLength);
        }

        Console.WriteLine(maxLength);
    }
}