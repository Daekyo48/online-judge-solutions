class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int count = 0;

        for (int i = 0; i < n; i++)
        {
            int d = int.Parse(Console.ReadLine()!);

            if (d % 2 == 1)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}