class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        int n = int.Parse(reader.ReadLine()!);

        Stack stack = new(n - 1);

        for (int i = 0; i < n; i++)
        {
            string command = reader.ReadLine()!;

            switch (command[0])
            {
                case '1':
                    int x = int.Parse(command.AsSpan(2));
                    stack.Push(x);
                    break;
                case '2':
                    writer.WriteLine(stack.Pop());
                    break;
                case '3':
                    writer.WriteLine(stack.Count());
                    break;
                case '4':
                    writer.WriteLine(stack.IsEmpty() ? 1 : 0);
                    break;
                case '5':
                    writer.WriteLine(stack.Peek());
                    break;
            }
        }

        writer.Close();
    }
}

class Stack
{
    int[] array;

    int top = 0;

    public Stack(int capacity)
    {
        array = new int[capacity];
    }

    public void Push(int item)
    {
        if (top < array.Length)
        {
            array[top++] = item;
        }
    }

    public int Pop()
    {
        return !IsEmpty() ? array[--top] : -1;
    }

    public int Count()
    {
        return top;
    }

    public bool IsEmpty()
    {
        return top == 0;
    }

    public int Peek()
    {
        return !IsEmpty() ? array[top - 1] : -1;
    }
}