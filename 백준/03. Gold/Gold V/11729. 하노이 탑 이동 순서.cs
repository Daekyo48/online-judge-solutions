class Program
{
    static StreamReader reader = new(new BufferedStream(Console.OpenStandardInput(), 131072));
    static StreamWriter writer = new(new BufferedStream(Console.OpenStandardOutput(), 131072));

    static void Main()
    {
        int n = int.Parse(reader.ReadLine()!);

        Console.WriteLine((1 << n) - 1);

        TowerOfHanoi(n, 1, 3);

        writer.Close();
    }

    static void TowerOfHanoi(int count, int source, int destination)
    {
        if (count == 0) return;

        int auxiliary = 6 - source - destination;

        TowerOfHanoi(count - 1, source, auxiliary);

        writer.WriteLine($"{source} {destination}");

        TowerOfHanoi(count - 1, auxiliary, destination);
    }
}