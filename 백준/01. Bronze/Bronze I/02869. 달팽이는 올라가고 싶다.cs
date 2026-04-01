class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine()!.Split();
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        int v = int.Parse(inputs[2]);

        int day = (v - b) / (a - b);

        if ((v - b) % (a - b) != 0)
        {
            day++;
        }

        Console.WriteLine(day);
    }
}