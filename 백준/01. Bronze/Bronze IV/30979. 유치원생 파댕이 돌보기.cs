class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);
        Console.ReadLine();

        int totalFlavor = 0;

        foreach (string value in Console.ReadLine()!.Split())
        {
            int f = int.Parse(value);

            totalFlavor += f;

            if (totalFlavor >= t)
            {
                Console.WriteLine("Padaeng_i Happy");
                return;
            }
        }

        Console.WriteLine("Padaeng_i Cry");
    }
}