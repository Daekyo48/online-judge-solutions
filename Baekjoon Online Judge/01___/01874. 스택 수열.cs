class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        int n = int.Parse(reader.ReadLine()!);

        Stack<int> stack = new();
        List<char> symbols = new();
        int nextNumber = 1;

        for (int i = 0; i < n; i++)
        {
            int term = int.Parse(reader.ReadLine()!);

            while (nextNumber <= term)
            {
                stack.Push(nextNumber++);
                symbols.Add('+');
            }

            if (stack.Peek() != term)
            {
                writer.WriteLine("NO");
                writer.Close();
                return;
            }

            stack.Pop();
            symbols.Add('-');
        }

        foreach (char symbol in symbols)
        {
            writer.WriteLine(symbol);
        }

        writer.Close();
    }
}