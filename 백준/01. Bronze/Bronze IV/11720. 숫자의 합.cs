class Program
{
    static void Main()
    {
        Console.ReadLine();

        int sum = 0;

        foreach (char digit in Console.ReadLine()!)
        {
            sum += digit - '0';
        }

        Console.WriteLine(sum);
    }
}