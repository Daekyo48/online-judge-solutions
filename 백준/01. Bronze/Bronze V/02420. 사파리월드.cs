class Program
{
    static void Main()
    {
        string[] popularities = Console.ReadLine()!.Split();
        long n = long.Parse(popularities[0]);
        long m = long.Parse(popularities[1]);

        Console.WriteLine(Math.Abs(n - m));
    }
}