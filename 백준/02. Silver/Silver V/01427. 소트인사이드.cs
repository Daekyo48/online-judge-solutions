class Program
{
    static void Main()
    {
        string n = Console.ReadLine()!;

        char[] digits = n.ToCharArray();

        Array.Sort(digits);

        for (int i = 1; i <= digits.Length; i++)
        {
            Console.Write(digits[^i]);
        }
    }
}