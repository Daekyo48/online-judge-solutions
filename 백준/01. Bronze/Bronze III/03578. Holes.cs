class Program
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine()!);

        if (h == 0)
        {
            Console.WriteLine(1);
            return;
        }

        if (h == 1)
        {
            Console.WriteLine(0);
            return;
        }

        if (h % 2 == 1)
        {
            Console.Write('4');
        }

        Console.WriteLine(new string('8', h / 2));
    }
}