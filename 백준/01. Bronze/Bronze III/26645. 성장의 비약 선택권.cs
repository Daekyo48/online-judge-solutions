class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        if (n > 228)
        {
            Console.WriteLine(4);
        }
        else if (n > 217)
        {
            Console.WriteLine(3);
        }
        else if (n > 205)
        {
            Console.WriteLine(2);
        }
        else
        {
            Console.WriteLine(1);
        }
    }
}