class Program
{
    static void Main()
    {
        int angleA = int.Parse(Console.ReadLine()!);
        int angleB = int.Parse(Console.ReadLine()!);
        int angleC = int.Parse(Console.ReadLine()!);

        if (angleA + angleB + angleC != 180)
        {
            Console.WriteLine("Error");
            return;
        }

        if (angleA == angleB && angleB == angleC)
        {
            Console.WriteLine("Equilateral");
        }
        else if (angleA == angleB || angleB == angleC || angleA == angleC)
        {
            Console.WriteLine("Isosceles");
        }
        else
        {
            Console.WriteLine("Scalene");
        }
    }
}