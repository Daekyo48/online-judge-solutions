class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int m = int.Parse(values[1]);

        int[] cards = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        int closestSum = 0;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i + 1; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    int sum = cards[i] + cards[j] + cards[k];

                    if (m == sum)
                    {
                        Console.WriteLine(m);
                        return;
                    }

                    closestSum = sum < m && sum > closestSum ? sum : closestSum;
                }
            }
        }

        Console.WriteLine(closestSum);
    }
}