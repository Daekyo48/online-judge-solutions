class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int[] numbers = new int[n];
        int[] counts = new int[8001];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine()!);

            numbers[i] = number;
            counts[number + 4000]++;
            sum += number;
        }

        Array.Sort(numbers);

        int maxCount = 0;
        int mode = 0;
        bool isSecondSmallest = false;

        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] == 0) continue;

            if (counts[i] > maxCount)
            {
                maxCount = counts[i];
                mode = i;
                isSecondSmallest = false;
            }
            else if (counts[i] == maxCount && !isSecondSmallest)
            {
                mode = i;
                isSecondSmallest = true;
            }
        }

        Console.WriteLine((int)Math.Round((double)sum / n, MidpointRounding.AwayFromZero));
        Console.WriteLine(numbers[n / 2]);
        Console.WriteLine(mode - 4000);
        Console.WriteLine(numbers[^1] - numbers[0]);
    }
}