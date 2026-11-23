class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int[] table = new int[n];
        int maxLength = 0;

        for (int i = 0; i < n; i++)
        {
            table[i] = 1;

            for (int j = 0; j < i; j++)
            {
                if (a[i] > a[j])
                {
                    table[i] = Math.Max(table[i], table[j] + 1);
                }
            }

            maxLength = Math.Max(table[i], maxLength);
        }

        Console.WriteLine(maxLength);
    }
}