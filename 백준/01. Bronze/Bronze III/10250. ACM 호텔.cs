class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string[] inputs = Console.ReadLine()!.Split();
            int h = int.Parse(inputs[0]);
            int n = int.Parse(inputs[2]);

            int floor = (n - 1) % h + 1;
            int room = (n - 1) / h + 1;

            Console.WriteLine($"{floor}{room:D2}");
        }
    }
}