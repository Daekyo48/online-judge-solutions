class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        int n = int.Parse(reader.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int rowIndex = i;
                int columnIndex = j;
                char star = '*';

                while (rowIndex > 0 || columnIndex > 0)
                {
                    if (rowIndex % 3 == 1 && columnIndex % 3 == 1)
                    {
                        star = ' ';
                        break;
                    }

                    rowIndex /= 3;
                    columnIndex /= 3;
                }

                writer.Write(star);
            }

            writer.WriteLine();
        }

        writer.Close();
    }
}