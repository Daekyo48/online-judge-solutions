class Program
{
    static void Main()
    {
        int[,,] memo = new int[21, 21, 21];

        string value;

        while ((value = Console.ReadLine()!) != "-1 -1 -1")
        {
            string[] numbers = value.Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);

            Console.WriteLine($"w({a}, {b}, {c}) = {W(a, b, c)}");
        }

        int W(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return 1;
            if (a > 20 || b > 20 || c > 20) return W(20, 20, 20);

            if (memo[a, b, c] != 0) return memo[a, b, c];

            if (a < b && b < c)
            {
                memo[a, b, c] = W(a, b, c - 1) + W(a, b - 1, c - 1) - W(a, b - 1, c);
            }
            else
            {
                memo[a, b, c] = W(a - 1, b, c) + W(a - 1, b - 1, c) + W(a - 1, b, c - 1) - W(a - 1, b - 1, c - 1);
            }

            return memo[a, b, c];
        }
    }
}