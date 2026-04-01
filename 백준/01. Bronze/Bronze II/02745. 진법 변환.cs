class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine()!.Split();
        string n = inputs[0];
        int b = int.Parse(inputs[1]);

        int decimalNumber = 0;

        foreach (char character in n)
        {
            int digit = character < 'A' ? character - '0' : character - 'A' + 10;

            decimalNumber = decimalNumber * b + digit;
        }

        Console.WriteLine(decimalNumber);
    }
}