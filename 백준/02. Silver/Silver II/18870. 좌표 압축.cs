class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        int n = int.Parse(reader.ReadLine()!);
        int[] xs = Array.ConvertAll(reader.ReadLine()!.Split(), int.Parse);

        Dictionary<int, int> xToIndex = new();
        int[] sortedXs = new int[n];
        int compressedIndex = 0;

        Array.Copy(xs, sortedXs, n);
        Array.Sort(sortedXs);

        xToIndex[sortedXs[0]] = compressedIndex++;

        for (int i = 1; i < n; i++)
        {
            if (sortedXs[i - 1] == sortedXs[i]) continue;

            xToIndex[sortedXs[i]] = compressedIndex++;
        }

        for (int i = 0; i < n; i++)
        {
            writer.Write($"{xToIndex[xs[i]]} ");
        }

        writer.Close();
    }
}