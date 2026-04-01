class Program
{
    static void Main()
    {
        int lambda = int.Parse(Console.ReadLine()!);

        if (lambda >= 620)
        {
            Console.WriteLine("Red");
        }
        else if (lambda >= 590)
        {
            Console.WriteLine("Orange");
        }
        else if (lambda >= 570)
        {
            Console.WriteLine("Yellow");
        }
        else if (lambda >= 495)
        {
            Console.WriteLine("Green");
        }
        else if (lambda >= 450)
        {
            Console.WriteLine("Blue");
        }
        else if (lambda >= 425)
        {
            Console.WriteLine("Indigo");
        }
        else
        {
            Console.WriteLine("Violet");
        }
    }
}