class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        int count = 0;

        for (int i = 666; ; i++)
        {
            string digits = i.ToString();

            if (!digits.Contains("666")) continue;

            if (++count == n)
            {
                Console.WriteLine(i);
                return;
            }
        }
    }
}