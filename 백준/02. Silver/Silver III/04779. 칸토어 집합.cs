class Program
{
    static void Main()
    {
        string value;

        while ((value = Console.ReadLine()!) != null)
        {
            int n = int.Parse(value);

            int length = 1;

            for (int i = 0; i < n; i++)
            {
                length *= 3;
            }

            char[] cantorSet = new char[length];

            Array.Fill(cantorSet, ' ');

            CantorSet(cantorSet, 0, length);

            Console.WriteLine(cantorSet);
        }
    }

    static void CantorSet(char[] array, int offset, int length)
    {
        if (length == 1)
        {
            array[offset] = '-';
            return;
        }

        length /= 3;

        CantorSet(array, offset, length);
        CantorSet(array, offset + length * 2, length);
    }
}