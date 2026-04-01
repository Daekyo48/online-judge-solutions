class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        int n = int.Parse(reader.ReadLine()!);

        int[] numbers = new int[n];
        int[] buffer = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(reader.ReadLine()!);
        }

        MergeSort(numbers, buffer, 0, n - 1);

        for (int i = 0; i < n; i++)
        {
            writer.WriteLine(numbers[i]);
        }

        writer.Close();
    }

    static void MergeSort(int[] array, int[] buffer, int begin, int end)
    {
        if (begin >= end) return;

        int mid = (begin + end) / 2;

        MergeSort(array, buffer, begin, mid);
        MergeSort(array, buffer, mid + 1, end);

        int index = begin;
        int left = begin;
        int right = mid + 1;

        while (left <= mid && right <= end)
        {
            buffer[index++] = array[left] <= array[right] ? array[left++] : array[right++];
        }

        while (left <= mid)
        {
            buffer[index++] = array[left++];
        }

        while (right <= end)
        {
            buffer[index++] = array[right++];
        }

        for (int i = begin; i <= end; i++)
        {
            array[i] = buffer[i];
        }
    }
}