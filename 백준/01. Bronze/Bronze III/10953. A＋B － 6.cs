class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string[] values = Console.ReadLine()!.Split(',');
            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);

            Console.WriteLine(a + b);
        }
    }
}