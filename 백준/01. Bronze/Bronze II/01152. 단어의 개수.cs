class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine(words.Length);
    }
}