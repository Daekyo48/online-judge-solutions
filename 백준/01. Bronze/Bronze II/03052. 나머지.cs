class Program
{
    static void Main()
    {
        bool[] seen = new bool[42];
        int count = 0;

        for (int i = 0; i < 10; i++)
        {
            seen[int.Parse(Console.ReadLine()!) % 42] = true;
        }

        foreach (bool isSeen in seen)
        {
            if (isSeen)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}