class Program
{
    static void Main()
    {
        string values;

        while ((values = Console.ReadLine()!) != null)
        {
            string[] numbers = values.Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            Console.WriteLine(a + b);
        }
    }
}