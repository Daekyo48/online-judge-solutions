class Program
{
    static void Main()
    {
        string[] times = Console.ReadLine()!.Split();
        int hh = int.Parse(times[0]);
        int mm = int.Parse(times[1]);

        Console.WriteLine((hh - 9) * 60 + mm);
    }
}