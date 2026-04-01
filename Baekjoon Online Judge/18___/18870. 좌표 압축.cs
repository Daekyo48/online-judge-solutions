class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        int n = int.Parse(reader.ReadLine()!);
        int[] x = Array.ConvertAll(reader.ReadLine()!.Split(), int.Parse);

        Dictionary<int, int> xToIndex = new();
        int[] sortedX = new int[n];
        int compressedIndex = 0;

        Array.Copy(x, sortedX, n);
        Array.Sort(sortedX);

        xToIndex[sortedX[0]] = compressedIndex++;

        for (int i = 1; i < n; i++)
        {
            if (sortedX[i - 1] == sortedX[i]) continue;

            xToIndex[sortedX[i]] = compressedIndex++;
        }

        for (int i = 0; i < n; i++)
        {
            writer.Write($"{xToIndex[x[i]]} ");
        }

        writer.Close();
    }
}