class Program
{
    static void Main()
    {
        int testCount = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < testCount; i++)
        {
            string[] values = Console.ReadLine()!.Split();
            int n = int.Parse(values[0]);
            int m = int.Parse(values[1]);

            string[] priorities = Console.ReadLine()!.Split();

            Queue<(int priority, bool isTarget)> documents = new();
            int[] priorityCounts = new int[9];

            for (int j = 0; j < n; j++)
            {
                int priority = int.Parse(priorities[j]);

                documents.Enqueue((priority, j == m));
                priorityCounts[priority - 1]++;
            }

            int order = 0;
            bool isPrinted = false;

            for (int j = 9; j > 0 && !isPrinted; j--)
            {
                while (priorityCounts[j - 1] != 0)
                {
                    (int priority, bool isTarget) = documents.Dequeue();

                    if (priority == j)
                    {
                        order++;
                        priorityCounts[j - 1]--;

                        if (isTarget)
                        {
                            Console.WriteLine(order);

                            isPrinted = true;
                            break;
                        }
                    }
                    else
                    {
                        documents.Enqueue((priority, isTarget));
                    }
                }
            }
        }
    }
}