class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int remainingNumber = 1;

        while (remainingNumber * 2 <= n)
        {
            remainingNumber *= 2;
        }

        Console.WriteLine(remainingNumber);
    }
}