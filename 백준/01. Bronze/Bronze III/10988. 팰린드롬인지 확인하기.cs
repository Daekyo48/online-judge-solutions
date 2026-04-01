class Program
{
    static void Main()
    {
        string word = Console.ReadLine()!;

        Console.WriteLine(word.SequenceEqual(word.Reverse()) ? 1 : 0);
    }
}