class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int n = int.Parse(values[0]);
        int u = int.Parse(values[1]);
        int l = int.Parse(values[2]);

        if (n < 1000)
        {
            Console.WriteLine("Bad");
            return;
        }

        Console.WriteLine(u >= 8000 || l >= 260 ? "Very Good" : "Good");
    }
}