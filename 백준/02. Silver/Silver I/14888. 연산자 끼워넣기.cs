class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        int[] operatorCounts = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        int min = int.MaxValue;
        int max = int.MinValue;

        DepthFirstSearch(1, numbers[0]);

        Console.WriteLine(max);
        Console.WriteLine(min);

        void DepthFirstSearch(int depth, int accumulator)
        {
            if (depth == n)
            {
                min = Math.Min(accumulator, min);
                max = Math.Max(accumulator, max);
                return;
            }

            for (int i = 0; i < operatorCounts.Length; i++)
            {
                if (operatorCounts[i] == 0) continue;

                operatorCounts[i]--;

                switch (i)
                {
                    case 0:
                        DepthFirstSearch(depth + 1, accumulator + numbers[depth]);
                        break;
                    case 1:
                        DepthFirstSearch(depth + 1, accumulator - numbers[depth]);
                        break;
                    case 2:
                        DepthFirstSearch(depth + 1, accumulator * numbers[depth]);
                        break;
                    case 3:
                        DepthFirstSearch(depth + 1, accumulator / numbers[depth]);
                        break;
                }

                operatorCounts[i]++;
            }
        }
    }
}