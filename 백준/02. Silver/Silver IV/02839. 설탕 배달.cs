class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        if (n == 4 || n == 7)
        {
            Console.WriteLine(-1);
            return;
        }

        switch (n % 5)
        {
            case 0:
                Console.WriteLine(n / 5);
                break;
            case 1:
            case 3:
                Console.WriteLine(n / 5 + 1);
                break;
            case 2:
            case 4:
                Console.WriteLine(n / 5 + 2);
                break;
        }
    }
}