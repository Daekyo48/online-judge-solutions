class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string[] inputs = Console.ReadLine()!.Split();
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

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