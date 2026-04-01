class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine()!);
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            string[] receiptItem = Console.ReadLine()!.Split();
            int a = int.Parse(receiptItem[0]);
            int b = int.Parse(receiptItem[1]);

            x -= a * b;
        }

        Console.WriteLine(x == 0 ? "Yes" : "No");
    }
}