class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= t; i++)
        {
            string[] numbers = Console.ReadLine()!.Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            Console.WriteLine($"Case #{i}: {a + b}");
        }
    }
}