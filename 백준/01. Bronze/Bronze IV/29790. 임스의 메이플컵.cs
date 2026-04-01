class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine()!.Split();
        int n = int.Parse(inputs[0]);
        int u = int.Parse(inputs[1]);
        int l = int.Parse(inputs[2]);

        if (n < 1000)
        {
            Console.WriteLine("Bad");
            return;
        }

        Console.WriteLine(u >= 8000 || l >= 260 ? "Very Good" : "Good");
    }
}