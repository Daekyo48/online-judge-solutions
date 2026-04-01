class Program
{
    static void Main()
    {
        int sum = 0;

        foreach (string input in Console.ReadLine()!.Split())
        {
            int number = int.Parse(input);

            sum += number * number;
        }

        Console.WriteLine(sum % 10);
    }
}