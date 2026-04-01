class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string s = Console.ReadLine()!;

            int count = 0;

            foreach (char color in s)
            {
                if (color == 'a')
                {
                    count++;
                }
            }

            Console.WriteLine(Math.Min(count, s.Length - count));
        }
    }
}