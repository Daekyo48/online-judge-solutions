class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n * 2; i++)
        {
            char[] row = new string(' ', n * 4 + 2).ToCharArray();

            row[n * 2 - 1 - i] = '*';

            if (i < n)
            {
                row[n * 3 - i] = '*';
                row[n * 3 + i + 2] = '*';
            }
            else
            {
                row[n + i + 1] = '*';
                row[n * 5 - i + 1] = '*';
            }

            Console.WriteLine(row);
        }
    }
}