class Program
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine()!);

        Stack<int> ledger = new();
        int total = 0;

        for (int i = 0; i < k; i++)
        {
            int number = int.Parse(Console.ReadLine()!);

            if (number != 0)
            {
                ledger.Push(number);
                total += number;
            }
            else
            {
                total -= ledger.Pop();
            }
        }

        Console.WriteLine(total);
    }
}