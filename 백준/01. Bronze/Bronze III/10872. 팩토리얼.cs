class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine(Factorial(n));
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