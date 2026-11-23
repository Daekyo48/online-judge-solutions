class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] table = new int[3];

        for (int i = 0; i < n; i++)
        {
            int amount = int.Parse(Console.ReadLine());

            (table[0], table[1], table[2]) = (
                Math.Max(table[0], Math.Max(table[1], table[2])),
                table[0] + amount,
                table[1] + amount
            );
        }

        Console.WriteLine(Math.Max(table[0], Math.Max(table[1], table[2])));
    }
}