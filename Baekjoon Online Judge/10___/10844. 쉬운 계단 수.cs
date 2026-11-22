class Program
{
    const int modulus = 1000000000;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] table = new int[n + 1, 10];

        for (int i = 1; i < 10; i++)
        {
            table[1, i] = 1;
        }

        for (int i = 2; i <= n; i++)
        {
            table[i, 0] = table[i - 1, 1];
            table[i, 9] = table[i - 1, 8];

            for (int j = 1; j < 9; j++)
            {
                table[i, j] = (table[i - 1, j - 1] + table[i - 1, j + 1]) % modulus;
            }
        }

        int result = 0;

        for (int i = 0; i < 10; i++)
        {
            result = (result + table[n, i]) % modulus;
        }

        Console.WriteLine(result);
    }
}