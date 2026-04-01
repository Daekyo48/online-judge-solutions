class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string s = Console.ReadLine()!;

            int count = 0;

            while (count <= s.Length / 2)
            {
                count++;

                if (s[count - 1] != s[^count]) break;
            }

            Console.WriteLine($"{(count > s.Length / 2 ? 1 : 0)} {count}");
        }
    }
}