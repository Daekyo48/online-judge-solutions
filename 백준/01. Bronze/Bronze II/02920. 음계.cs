class Program
{
    static void Main()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        bool isAscending = true;
        bool isDescending = true;

        for (int i = 0; i < 7; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                isDescending = false;
            }
            else if (numbers[i] > numbers[i + 1])
            {
                isAscending = false;
            }
        }

        if (isAscending)
        {
            Console.WriteLine("ascending");
        }
        else if (isDescending)
        {
            Console.WriteLine("descending");
        }
        else
        {
            Console.WriteLine("mixed");
        }
    }
}