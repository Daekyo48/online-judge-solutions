class Program
{
    static void Main()
    {
        int sum = 0;

        foreach (string value in Console.ReadLine()!.Split())
        {
            int number = int.Parse(value);

            sum += number * number;
        }

        Console.WriteLine(sum % 10);
    }
}