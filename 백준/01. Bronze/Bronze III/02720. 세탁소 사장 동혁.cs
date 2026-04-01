class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            int c = int.Parse(Console.ReadLine()!);

            int quarter = c / 25;
            c %= 25;

            int dime = c / 10;
            c %= 10;

            int nickel = c / 5;
            c %= 5;

            int penny = c;

            Console.WriteLine($"{quarter} {dime} {nickel} {penny}");
        }
    }
}