class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        string[] values = Console.ReadLine()!.Split();

        LinkedList<(int index, int move)> balloons = new();
        int[] order = new int[n];

        for (int i = 0; i < n; i++)
        {
            balloons.AddLast((i + 1, int.Parse(values[i])));
        }

        for (int i = 0; i < n; i++)
        {
            (int index, int move) = balloons.First!.Value;
            balloons.RemoveFirst();

            order[i] = index;

            if (balloons.Count == 0) break;

            if (move > 0)
            {
                move = (move - 1) % balloons.Count;

                for (int j = 0; j < move; j++)
                {
                    balloons.AddLast(balloons.First!.Value);
                    balloons.RemoveFirst();
                }
            }
            else
            {
                move = -move % balloons.Count;

                for (int j = 0; j < move; j++)
                {
                    balloons.AddFirst(balloons.Last!.Value);
                    balloons.RemoveLast();
                }
            }
        }

        Console.WriteLine(string.Join(' ', order));
    }
}