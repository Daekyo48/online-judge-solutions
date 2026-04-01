class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine()!.Split();
        int n = int.Parse(inputs[0]);
        int k = int.Parse(inputs[1]);

        int[] scores = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        Array.Sort(scores);

        Console.WriteLine(scores[n - k]);
    }
}