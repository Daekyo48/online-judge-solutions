class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);
        int c = int.Parse(Console.ReadLine()!);

        int[] counts = new int[10];
        int product = a * b * c;

        while (product > 0)
        {
            counts[product % 10]++;
            product /= 10;
        }

        foreach (int count in counts)
        {
            Console.WriteLine(count);
        }
    }
}