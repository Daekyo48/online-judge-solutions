class Program
{
    static void Main()
    {
        Console.ReadLine();

        long hashValue = 0;
        long power = 1;

        foreach (char character in Console.ReadLine()!)
        {
            hashValue = (hashValue + (character - 'a' + 1) * power) % 1234567891;
            power = power * 31 % 1234567891;
        }

        Console.WriteLine(hashValue);
    }
}