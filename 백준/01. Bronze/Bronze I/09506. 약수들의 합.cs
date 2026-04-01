class Program
{
    static void Main()
    {
        string input;

        while ((input = Console.ReadLine()!) != "-1")
        {
            int n = int.Parse(input);

            List<int> factors = new();
            int sum = 0;

            for (int i = 1; i * 2 <= n; i++)
            {
                if (n % i == 0)
                {
                    factors.Add(i);
                    sum += i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine($"{n} = {string.Join(" + ", factors)}");
            }
            else
            {
                Console.WriteLine($"{n} is NOT perfect.");
            }
        }
    }
}