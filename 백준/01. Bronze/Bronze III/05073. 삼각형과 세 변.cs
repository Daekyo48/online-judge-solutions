class Program
{
    static void Main()
    {
        string values;

        while ((values = Console.ReadLine()!) != "0 0 0")
        {
            int[] lengths = Array.ConvertAll(values.Split(), int.Parse);

            Array.Sort(lengths);

            if (lengths[0] + lengths[1] <= lengths[2])
            {
                Console.WriteLine("Invalid");
                continue;
            }

            if (lengths[0] == lengths[2])
            {
                Console.WriteLine("Equilateral");
            }
            else if (lengths[0] == lengths[1] || lengths[1] == lengths[2])
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
        }
    }
}