class Program
{
    static void Main()
    {
        int[] pips = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        Array.Sort(pips);

        if (pips[0] == pips[2])
        {
            Console.WriteLine(10000 + pips[0] * 1000);
        }
        else if (pips[0] == pips[1] || pips[1] == pips[2])
        {
            Console.WriteLine(1000 + pips[1] * 100);
        }
        else
        {
            Console.WriteLine(pips[2] * 100);
        }
    }
}