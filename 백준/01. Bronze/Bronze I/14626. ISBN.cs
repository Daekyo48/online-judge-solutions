class Program
{
    static void Main()
    {
        string digits = Console.ReadLine()!;
        int checkDigit = digits[12] - '0';

        int sum = 0;
        int inverse = 0;

        for (int i = 0; i < 12; i++)
        {
            int weight = i % 2 == 0 ? 1 : 3;

            if (digits[i] != '*')
            {
                sum += (digits[i] - '0') * weight;
            }
            else
            {
                inverse = weight == 1 ? 1 : 7;
            }
        }

        Console.WriteLine((10 - (sum + checkDigit) % 10) * inverse % 10);
    }
}