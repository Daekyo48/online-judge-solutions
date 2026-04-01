class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!) / 4;

        for (int i = 0; i < n; i++)
        {
            Console.Write("long ");
        }

        Console.WriteLine("int");
    }
}