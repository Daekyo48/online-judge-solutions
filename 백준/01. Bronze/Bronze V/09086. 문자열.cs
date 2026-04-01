class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string word = Console.ReadLine()!;

            Console.Write(word[0]);
            Console.WriteLine(word[^1]);
        }
    }
}