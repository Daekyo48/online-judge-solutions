class Program
{
    static void Main()
    {
        Console.WriteLine(DateTime.UtcNow.AddHours(9).ToString("yyyy-MM-dd"));
    }
}