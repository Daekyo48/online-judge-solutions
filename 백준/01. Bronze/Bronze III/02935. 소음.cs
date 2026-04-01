class Program
{
    static void Main()
    {
        string a = Console.ReadLine()!;
        string symbol = Console.ReadLine()!;
        string b = Console.ReadLine()!;

        if (symbol == "+")
        {
            if (a.Length == b.Length)
            {
                Console.WriteLine($"2{new string('0', a.Length - 1)}");
                return;
            }

            if (a.Length < b.Length)
            {
                (a, b) = (b, a);
            }

            Console.WriteLine($"1{new string('0', a.Length - b.Length - 1)}{b}");
        }
        else
        {
            Console.WriteLine($"1{new string('0', a.Length + b.Length - 2)}");
        }
    }
}