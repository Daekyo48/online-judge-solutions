class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string[] values = Console.ReadLine()!.Split();
            int h = int.Parse(values[0]);
            int n = int.Parse(values[2]);

            int floor = (n - 1) % h + 1;
            int room = (n - 1) / h + 1;

            Console.WriteLine($"{floor}{room:D2}");
        }
    }
}