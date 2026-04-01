class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        int n = int.Parse(reader.ReadLine()!);

        int[] counts = new int[10000];

        for (int i = 0; i < n; i++)
        {
            counts[int.Parse(reader.ReadLine()!) - 1]++;
        }

        for (int i = 0; i < 10000; i++)
        {
            for (int j = 0; j < counts[i]; j++)
            {
                writer.WriteLine(i + 1);
            }
        }

        writer.Close();
    }
}