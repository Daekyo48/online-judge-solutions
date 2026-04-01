class Program
{
    static void Main()
    {
        string values;

        while ((values = Console.ReadLine()!) != "0 0")
        {
            string[] numbers = values.Split();
            int m = int.Parse(numbers[0]);
            int f = int.Parse(numbers[1]);

            Console.WriteLine(m + f);
        }
    }
}