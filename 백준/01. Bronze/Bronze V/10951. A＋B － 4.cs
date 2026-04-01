class Program
{
    static void Main()
    {
        string input;

        while ((input = Console.ReadLine()!) != null)
        {
            string[] numbers = input.Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            Console.WriteLine(a + b);
        }
    }
}