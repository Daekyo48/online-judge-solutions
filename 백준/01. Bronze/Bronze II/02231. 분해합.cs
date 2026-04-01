class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        for (int i = n - n.ToString().Length * 9; i < n; i++)
        {
            int decompositionSum = i;
            string digits = i.ToString();

            foreach (char digit in digits)
            {
                decompositionSum += digit - '0';
            }

            if (n == decompositionSum)
            {
                Console.WriteLine(i);
                return;
            }
        }

        Console.WriteLine(0);
    }
}