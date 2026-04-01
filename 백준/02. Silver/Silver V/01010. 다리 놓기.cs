class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string[] values = Console.ReadLine()!.Split();
            int n = int.Parse(values[0]);
            int m = int.Parse(values[1]);

            Console.WriteLine(Combination(m, n));
        }
    }

    static long Combination(int n, int r)
    {
        long combination = 1;

        r = Math.Min(r, n - r);

        for (int i = 1; i <= r; i++)
        {
            combination = combination * (n - r + i) / i;
        }

        return combination;
    }
}