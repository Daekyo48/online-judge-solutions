class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        int currentSum = numbers[0];
        int maxSum = numbers[0];

        for (int i = 1; i < n; i++)
        {
            currentSum = Math.Max(currentSum + numbers[i], numbers[i]);
            maxSum = Math.Max(currentSum, maxSum);
        }

        Console.WriteLine(maxSum);
    }
}