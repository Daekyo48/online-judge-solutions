class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string[] values = Console.ReadLine()!.Split();
            int r = int.Parse(values[0]);
            string s = values[1];

            foreach (char character in s)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(character);
                }
            }

            Console.WriteLine();
        }
    }
}