class Program
{
    static void Main()
    {
        string[] pages = Console.ReadLine()!.Split();
        int a = int.Parse(pages[0]);
        int b = int.Parse(pages[1]);

        Console.WriteLine((b + 1) / 2 - (a + 1) / 2 + 1);
    }
}