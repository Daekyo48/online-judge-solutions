class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int k = int.Parse(values[1]);

        Console.WriteLine(Factorial(n) / (Factorial(k) * Factorial(n - k)));
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