class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine()!.Split();
        int a = int.Parse(numbers[0]);
        int b = int.Parse(numbers[1]);
        int c = int.Parse(numbers[2]);
        
        Console.WriteLine((a + b) % c);
        Console.WriteLine(((a % c) + (b % c)) % c);
        Console.WriteLine((a * b) % c);
        Console.WriteLine(((a % c) * (b % c)) % c);
    }
}