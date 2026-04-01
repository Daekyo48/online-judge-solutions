class Program
{
    static void Main()
    {
        string values;

        while ((values = Console.ReadLine()!) != "0 0 0")
        {
            int[] sides = Array.ConvertAll(values.Split(), int.Parse);

            Array.Sort(sides);

            bool isRightTriangle = sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];

            Console.WriteLine(isRightTriangle ? "right" : "wrong");
        }
    }
}