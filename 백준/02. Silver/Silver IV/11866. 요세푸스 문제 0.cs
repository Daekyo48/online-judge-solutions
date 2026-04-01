class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int k = int.Parse(values[1]);

        Queue<int> people = new();
        int[] permutation = new int[n];

        for (int i = 1; i <= n; i++)
        {
            people.Enqueue(i);
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k - 1; j++)
            {
                people.Enqueue(people.Dequeue());
            }

            permutation[i] = people.Dequeue();
        }

        Console.WriteLine($"<{string.Join(", ", permutation)}>");
    }
}