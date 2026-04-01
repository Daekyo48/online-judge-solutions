class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int maxPower = 1;

        while (maxPower * 2 <= n)
        {
            maxPower *= 2;
        }

        Console.WriteLine(n == maxPower ? n : (n - maxPower) * 2);
    }
}