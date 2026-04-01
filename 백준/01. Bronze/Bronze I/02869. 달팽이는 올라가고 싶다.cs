class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int a = int.Parse(values[0]);
        int b = int.Parse(values[1]);
        int v = int.Parse(values[2]);

        int day = (v - b) / (a - b);

        if ((v - b) % (a - b) != 0)
        {
            day++;
        }

        Console.WriteLine(day);
    }
}