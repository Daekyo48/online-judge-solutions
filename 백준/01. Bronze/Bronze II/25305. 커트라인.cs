class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int k = int.Parse(values[1]);

        int[] scores = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        Array.Sort(scores);

        Console.WriteLine(scores[n - k]);
    }
}