class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        int n = int.Parse(reader.ReadLine()!);

        Deque deque = new(n - 1);

        for (int i = 0; i < n; i++)
        {
            string command = reader.ReadLine()!;
            int x;

            switch (command[0])
            {
                case '1':
                    x = int.Parse(command.AsSpan(2));
                    deque.AddFront(x);
                    break;
                case '2':
                    x = int.Parse(command.AsSpan(2));
                    deque.AddBack(x);
                    break;
                case '3':
                    writer.WriteLine(deque.RemoveFront());
                    break;
                case '4':
                    writer.WriteLine(deque.RemoveBack());
                    break;
                case '5':
                    writer.WriteLine(deque.Count());
                    break;
                case '6':
                    writer.WriteLine(deque.IsEmpty() ? 1 : 0);
                    break;
                case '7':
                    writer.WriteLine(deque.PeekFront());
                    break;
                case '8':
                    writer.WriteLine(deque.PeekBack());
                    break;
            }
        }

        writer.Close();
    }
}

class Deque
{
    int[] array;

    int count = 0;
    int front = 0;
    int rear = 0;

    public Deque(int capacity)
    {
        array = new int[capacity];
    }

    public void AddFront(int item)
    {
        if (count < array.Length)
        {
            front = (front - 1 + array.Length) % array.Length;
            array[front] = item;
            count++;
        }
    }

    public void AddBack(int item)
    {
        if (count < array.Length)
        {
            array[rear] = item;
            rear = (rear + 1) % array.Length;
            count++;
        }
    }

    public int RemoveFront()
    {
        int item = -1;

        if (!IsEmpty())
        {
            item = array[front];
            front = (front + 1) % array.Length;
            count--;
        }

        return item;
    }

    public int RemoveBack()
    {
        int item = -1;

        if (!IsEmpty())
        {
            rear = (rear - 1 + array.Length) % array.Length;
            item = array[rear];
            count--;
        }

        return item;
    }

    public int Count()
    {
        return count;
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public int PeekFront()
    {
        return !IsEmpty() ? array[front] : -1;
    }

    public int PeekBack()
    {
        return !IsEmpty() ? array[(rear - 1 + array.Length) % array.Length] : -1;
    }
}