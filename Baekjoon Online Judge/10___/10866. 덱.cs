class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        int n = int.Parse(reader.ReadLine()!);

        Deque deque = new(n);

        for (int i = 0; i < n; i++)
        {
            string[] command = reader.ReadLine()!.Split();
            int x;

            switch (command[0])
            {
                case "push_front":
                    x = int.Parse(command[1]);
                    deque.AddFront(x);
                    break;
                case "push_back":
                    x = int.Parse(command[1]);
                    deque.AddBack(x);
                    break;
                case "pop_front":
                    writer.WriteLine(deque.RemoveFront());
                    break;
                case "pop_back":
                    writer.WriteLine(deque.RemoveBack());
                    break;
                case "size":
                    writer.WriteLine(deque.Count());
                    break;
                case "empty":
                    writer.WriteLine(deque.IsEmpty() ? 1 : 0);
                    break;
                case "front":
                    writer.WriteLine(deque.PeekFront());
                    break;
                case "back":
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