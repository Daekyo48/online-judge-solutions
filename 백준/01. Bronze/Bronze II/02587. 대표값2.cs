class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            int number = int.Parse(Console.ReadLine()!);

            numbers[i] = number;
            sum += number;
        }

        Array.Sort(numbers);

        Console.WriteLine(sum / 5);
        Console.WriteLine(numbers[2]);
    }
}