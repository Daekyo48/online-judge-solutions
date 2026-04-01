class Program
{
    static void Main()
    {
        string value;

        while ((value = Console.ReadLine()!) != "-1")
        {
            int n = int.Parse(value);

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