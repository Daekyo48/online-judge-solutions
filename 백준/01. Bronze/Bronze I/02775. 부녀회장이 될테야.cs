class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            int k = int.Parse(Console.ReadLine()!);
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine(Combination(k + n, k + 1));
        }
    }

    static int Combination(int n, int r)
    {
        int combination = 1;

        r = Math.Min(r, n - r);

        for (int i = 1; i <= r; i++)
        {
            combination = combination * (n - r + i) / i;
        }

        return combination;
    }
}