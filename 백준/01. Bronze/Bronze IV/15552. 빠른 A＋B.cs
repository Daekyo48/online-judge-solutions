class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        int t = int.Parse(reader.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string[] numbers = reader.ReadLine()!.Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            writer.WriteLine(a + b);
        }

        writer.Close();
    }
}