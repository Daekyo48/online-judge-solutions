class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        char[][] solvedProblems =
        {
            new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'L', 'M' },
            new char[] { 'A', 'C', 'E', 'F', 'G', 'H', 'I', 'L', 'M' },
            new char[] { 'A', 'C', 'E', 'F', 'G', 'H', 'I', 'L', 'M' },
            new char[] { 'A', 'B', 'C', 'E', 'F', 'G', 'H', 'L', 'M' },
            new char[] { 'A', 'C', 'E', 'F', 'G', 'H', 'L', 'M' },
            new char[] { 'A', 'C', 'E', 'F', 'G', 'H', 'L', 'M' },
            new char[] { 'A', 'C', 'E', 'F', 'G', 'H', 'L', 'M' },
            new char[] { 'A', 'C', 'E', 'F', 'G', 'H', 'L', 'M' },
            new char[] { 'A', 'C', 'E', 'F', 'G', 'H', 'L', 'M' },
            new char[] { 'A', 'B', 'C', 'F', 'G', 'H', 'L', 'M' }
        };

        Console.WriteLine(solvedProblems[n - 1].Length);
        Console.WriteLine(string.Join(' ', solvedProblems[n - 1]));
    }
}