class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        string n = values[0];
        int b = int.Parse(values[1]);

        int decimalNumber = 0;

        foreach (char character in n)
        {
            int digit = character < 'A' ? character - '0' : character - 'A' + 10;

            decimalNumber = decimalNumber * b + digit;
        }

        Console.WriteLine(decimalNumber);
    }
}