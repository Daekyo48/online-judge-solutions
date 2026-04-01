class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine()!);

        int diagonal = 1;

        while (diagonal * (diagonal + 1) / 2 < x)
        {
            diagonal++;
        }

        int position = x - (diagonal - 1) * diagonal / 2;

        if (diagonal % 2 == 0)
        {
            Console.WriteLine($"{position}/{diagonal - position + 1}");
        }
        else
        {
            Console.WriteLine($"{diagonal - position + 1}/{position}");
        }
    }
}