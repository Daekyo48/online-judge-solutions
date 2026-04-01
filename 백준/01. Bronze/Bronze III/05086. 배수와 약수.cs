class Program
{
    static void Main()
    {
        string values;

        while ((values = Console.ReadLine()!) != "0 0")
        {
            string[] numbers = values.Split();
            int numberA = int.Parse(numbers[0]);
            int numberB = int.Parse(numbers[1]);

            if (numberB % numberA == 0)
            {
                Console.WriteLine("factor");
            }
            else if (numberA % numberB == 0)
            {
                Console.WriteLine("multiple");
            }
            else
            {
                Console.WriteLine("neither");
            }
        }
    }
}