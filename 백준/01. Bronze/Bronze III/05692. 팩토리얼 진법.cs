class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        string input;

        while ((input = reader.ReadLine()!) != "0")
        {
            int decimalNumber = 0;

            for (int i = 1; i <= input.Length; i++)
            {
                decimalNumber += (input[^i] - '0') * Factorial(i);
            }

            writer.WriteLine(decimalNumber);
        }

        writer.Close();
    }

    static int Factorial(int n)
    {
        int factorial = 1;

        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}