class Program
{
    static void Main()
    {
        int sum = 91;

        for (int i = 0; i < 3; i++)
        {
            int weight = i % 2 == 0 ? 1 : 3;

            sum += int.Parse(Console.ReadLine()!) * weight;
        }

        Console.WriteLine($"The 1-3-sum is {sum}");
    }
}