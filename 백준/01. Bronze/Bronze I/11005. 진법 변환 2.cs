class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int b = int.Parse(values[1]);

        string baseBNumber = string.Empty;

        while (n > 0)
        {
            int digit = n % b < 10 ? n % b + '0' : n % b + 'A' - 10;

            baseBNumber = (char)digit + baseBNumber;
            n /= b;
        }

        Console.WriteLine(baseBNumber);
    }
}