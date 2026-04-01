class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        reader.ReadLine();
        int[] a = Array.ConvertAll(reader.ReadLine()!.Split(), int.Parse);

        int m = int.Parse(reader.ReadLine()!);
        int[] numbers = Array.ConvertAll(reader.ReadLine()!.Split(), int.Parse);

        Array.Sort(a);

        for (int i = 0; i < m; i++)
        {
            writer.WriteLine(BinarySearch(a, numbers[i]));
        }

        writer.Close();
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (array[mid] == target) return 1;

            if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return 0;
    }
}