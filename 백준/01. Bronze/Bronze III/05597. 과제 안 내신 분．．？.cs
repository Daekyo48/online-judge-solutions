class Program
{
    static void Main()
    {
        bool[] seen = new bool[30];

        for (int i = 0; i < 28; i++)
        {
            seen[int.Parse(Console.ReadLine()!) - 1] = true;
        }

        for (int i = 0; i < 30; i++)
        {
            if (!seen[i])
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}