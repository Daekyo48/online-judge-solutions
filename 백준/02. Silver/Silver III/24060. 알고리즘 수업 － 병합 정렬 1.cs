class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int k = int.Parse(values[1]);

        int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        Console.WriteLine(FindMergeElement(a, 0, n - 1, ref k));
    }

    static int FindMergeElement(int[] array, int begin, int end, ref int order)
    {
        if (begin >= end) return -1;

        int mid = (begin + end) / 2;

        int left = FindMergeElement(array, begin, mid, ref order);
        if (left != -1) return left;

        int right = FindMergeElement(array, mid + 1, end, ref order);
        if (right != -1) return right;

        int length = end - begin + 1;

        if (order > length)
        {
            order -= length;
            return -1;
        }

        Array.Sort(array, begin, length);

        return array[begin + order - 1];
    }
}