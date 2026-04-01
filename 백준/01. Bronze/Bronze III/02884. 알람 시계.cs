class Program
{
    static void Main()
    {
        string[] times = Console.ReadLine()!.Split();
        int h = int.Parse(times[0]);
        int m = int.Parse(times[1]) - 45;

        if (m < 0)
        {
            h--;
            m += 60;
        }

        if (h < 0)
        {
            h = 23;
        }

        Console.WriteLine($"{h} {m}");
    }
}