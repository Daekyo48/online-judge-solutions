class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        int n = int.Parse(reader.ReadLine()!);

        Queue queue = new(n);

        for (int i = 0; i < n; i++)
        {
            string[] command = reader.ReadLine()!.Split();

            switch (command[0])
            {
                case "push":
                    int x = int.Parse(command[1]);
                    queue.Enqueue(x);
                    break;
                case "pop":
                    writer.WriteLine(queue.Dequeue());
                    break;
                case "size":
                    writer.WriteLine(queue.Count());
                    break;
                case "empty":
                    writer.WriteLine(queue.IsEmpty() ? 1 : 0);
                    break;
                case "front":
                    writer.WriteLine(queue.PeekFront());
                    break;
                case "back":
                    writer.WriteLine(queue.PeekBack());
                    break;
            }
        }

        writer.Close();
    }
}

class Queue
{
    int[] array;

    int front = 0;
    int rear = 0;

    public Queue(int capacity)
    {
        array = new int[capacity];
    }

    public void Enqueue(int item)
    {
        if (rear < array.Length)
        {
            array[rear++] = item;
        }
    }

    public int Dequeue()
    {
        return !IsEmpty() ? array[front++] : -1;
    }

    public int Count()
    {
        return rear - front;
    }

    public bool IsEmpty()
    {
        return front == rear;
    }

    public int PeekFront()
    {
        return !IsEmpty() ? array[front] : -1;
    }

    public int PeekBack()
    {
        return !IsEmpty() ? array[rear - 1] : -1;
    }
}