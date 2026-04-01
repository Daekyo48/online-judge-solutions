class Program
{
    static void Main()
    {
        int nextNumber = 0;

        for (int i = 0; i < 3; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                nextNumber = number - i + 3;
                break;
            }
        }

        if (nextNumber % 15 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (nextNumber % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (nextNumber % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(nextNumber);
        }
    }
}