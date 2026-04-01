class Program
{
    static void Main()
    {
        string[] mice = Console.ReadLine()!.Split();
        int marked = int.Parse(mice[0]);
        int captured = int.Parse(mice[1]);
        int recaptured = int.Parse(mice[2]);

        Console.WriteLine((marked + 1) * (captured + 1) / (recaptured + 1) - 1);
    }
}