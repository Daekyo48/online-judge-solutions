class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string[] inputs = Console.ReadLine()!.Split();
            long n = long.Parse(inputs[0]);
            long k = Math.Min(n - 1, long.Parse(inputs[1]));

            Console.WriteLine((n * 2 - k) * (k + 1) * 2);
        }
    }
}